using AutoCons.Helpers;
using AutoCons.Models;
using AutoCons.Services;
using System.Data;
using System.Text.Json;

namespace AutoCons.Forms
{
    public partial class ReceiverConfigForm : Form
    {
        private static readonly string ConfigPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config_receiver.json");

        private DataTable? _csvTable;

        public ReceiverConfigForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            lblReplyTemplate.Text = " Template del messaggio di risposta:\r\nUsa i tag <notfound>...</notfound> per racchiudere la sezione che apparirà SOLO se ci sono numeri non trovati. \r\n Usa {numbers} all'interno per il segnaposto dei numeri non trovati.";
            LoadConfig();
        }

        private void btnBrowseCsv_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Seleziona file CSV consensi",
                Filter = "File CSV|*.csv;*.txt|Tutti i file|*.*"
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            txtCsvFile.Text = dlg.FileName;
            LoadCsvPreview(dlg.FileName);
        }

        private void LoadCsvPreview(string filePath)
        {
            try
            {
                var (table, separator, hasHeader) = CsvSmartReader.ReadWithMeta(filePath);
                _csvTable = table;

                // Populate column selector
                cmbPhoneColumn.Items.Clear();
                foreach (DataColumn col in table.Columns)
                    cmbPhoneColumn.Items.Add(col.ColumnName);

                if (cmbPhoneColumn.Items.Count > 0)
                    cmbPhoneColumn.SelectedIndex = 0;

                // Show preview (first 100 rows)
                var preview = table.Clone();
                for (int i = 0; i < Math.Min(100, table.Rows.Count); i++)
                    preview.ImportRow(table.Rows[i]);

                dgvCsvPreview.DataSource = preview;

                string sepDisplay = separator == '\t' ? "TAB" : separator.ToString();
                lblCsvInfo.Text = $"Righe totali: {table.Rows.Count} | Colonne: {table.Columns.Count} | Separatore: '{sepDisplay}' | Header: {(hasHeader ? "Sì" : "No")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore caricamento CSV: {ex.Message}", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var config = BuildConfig();
            SaveConfig(config);
            MessageBox.Show("Configurazione salvata con successo.", "Salvataggio",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            LoadConfig();
            MessageBox.Show("Configurazione caricata.", "Caricamento",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var config = BuildConfig();
            try
            {
                SchedulerService.CreateOrUpdateReceiverTask(config.CheckTime);
                MessageBox.Show("Task pianificato in Windows Task Scheduler.", "Pianificazione",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore pianificazione: {ex.Message}", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCheckNow_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var config = BuildConfig();
            btnCheckNow.Enabled = false;
            try
            {
                var service = new ReceiverService(config);
                await service.RunAsync();
                MessageBox.Show("Controllo completato.", "Controllo completato",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore controllo: {ex.Message}", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCheckNow.Enabled = true;
            }
        }

        private void btnViewHistory_Click(object sender, EventArgs e)
        {
            pnlHistory.Visible = !pnlHistory.Visible;
            if (pnlHistory.Visible)
                LoadHistory();
        }

        private void LoadHistory()
        {
            var processed = RegistryHelper.LoadAllValues("Receiver\\ProcessedEmails");
            dgvHistory.DataSource = null;
            var dt = new DataTable();
            dt.Columns.Add("Message-ID", typeof(string));
            dt.Columns.Add("Data Elaborazione", typeof(string));

            foreach (var kv in processed.OrderByDescending(kv => kv.Value))
                dt.Rows.Add(kv.Key, kv.Value);

            dgvHistory.DataSource = dt;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtImapServer.Text))
            {
                MessageBox.Show("Inserire il server IMAP.", "Validazione",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCsvFile.Text))
            {
                MessageBox.Show("Selezionare il file CSV dei consensi.", "Validazione",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private ReceiverConfig BuildConfig()
        {
            return new ReceiverConfig
            {
                ImapServer = txtImapServer.Text,
                ImapPort = (int)nudImapPort.Value,
                ImapUseSsl = chkImapSsl.Checked,
                ImapUsername = txtImapUsername.Text,
                ImapPassword = txtImapPassword.Text,
                ImapPasswordEncrypted = CryptoHelper.Encrypt(txtImapPassword.Text),

                SmtpServer = txtSmtpServer.Text,
                SmtpPort = (int)nudSmtpPort.Value,
                SmtpUseSsl = chkSmtpSsl.Checked,
                SmtpUsername = txtSmtpUsername.Text,
                SmtpPassword = txtSmtpPassword.Text,
                SmtpPasswordEncrypted = CryptoHelper.Encrypt(txtSmtpPassword.Text),
                SenderDisplayName = txtSenderDisplayName.Text,

                SentImapServer = txtSentImapServer.Text,
                SentImapPort = (int)nudSentImapPort.Value,
                SentImapUseSsl = chkSentImapSsl.Checked,

                MonitoredSenderEmail = txtMonitoredSender.Text,
                CheckTime = tpCheckTime.Value.TimeOfDay,

                CsvFilePath = txtCsvFile.Text,
                PhoneColumnName = cmbPhoneColumn.Text,
                SharedHmacKey = txtHmacKey.Text,
                ReplyTemplate = txtReplyTemplate.Text
            };
        }

        private void SaveConfig(ReceiverConfig config)
        {
            var toSave = new ReceiverConfig
            {
                ImapServer = config.ImapServer,
                ImapPort = config.ImapPort,
                ImapUseSsl = config.ImapUseSsl,
                ImapUsername = config.ImapUsername,
                ImapPasswordEncrypted = config.ImapPasswordEncrypted,

                SmtpServer = config.SmtpServer,
                SmtpPort = config.SmtpPort,
                SmtpUseSsl = config.SmtpUseSsl,
                SmtpUsername = config.SmtpUsername,
                SmtpPasswordEncrypted = config.SmtpPasswordEncrypted,
                SenderDisplayName = config.SenderDisplayName,

                SentImapServer = config.SentImapServer,
                SentImapPort = config.SentImapPort,
                SentImapUseSsl = config.SentImapUseSsl,

                MonitoredSenderEmail = config.MonitoredSenderEmail,
                CheckTime = config.CheckTime,

                CsvFilePath = config.CsvFilePath,
                PhoneColumnName = config.PhoneColumnName,
                SharedHmacKey = config.SharedHmacKey,
                ReplyTemplate = config.ReplyTemplate
            };

            var json = JsonSerializer.Serialize(toSave, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ConfigPath, json, System.Text.Encoding.UTF8);
        }

        private void LoadConfig()
        {
            if (!File.Exists(ConfigPath)) return;

            try
            {
                var json = File.ReadAllText(ConfigPath);
                var config = JsonSerializer.Deserialize<ReceiverConfig>(json);
                if (config == null) return;

                txtImapServer.Text = config.ImapServer;
                nudImapPort.Value = config.ImapPort;
                chkImapSsl.Checked = config.ImapUseSsl;
                txtImapUsername.Text = config.ImapUsername;
                txtImapPassword.Text = CryptoHelper.Decrypt(config.ImapPasswordEncrypted);

                txtSmtpServer.Text = config.SmtpServer;
                nudSmtpPort.Value = config.SmtpPort;
                chkSmtpSsl.Checked = config.SmtpUseSsl;
                txtSmtpUsername.Text = config.SmtpUsername;
                txtSmtpPassword.Text = CryptoHelper.Decrypt(config.SmtpPasswordEncrypted);
                txtSenderDisplayName.Text = config.SenderDisplayName;

                txtSentImapServer.Text = config.SentImapServer;
                nudSentImapPort.Value = config.SentImapPort;
                chkSentImapSsl.Checked = config.SentImapUseSsl;

                txtMonitoredSender.Text = config.MonitoredSenderEmail;
                tpCheckTime.Value = DateTime.Today.Add(config.CheckTime);

                txtCsvFile.Text = config.CsvFilePath;
                txtHmacKey.Text = config.SharedHmacKey;
                txtReplyTemplate.Text = config.ReplyTemplate;

                if (File.Exists(config.CsvFilePath))
                {
                    LoadCsvPreview(config.CsvFilePath);
                    // Restore column selection
                    if (!string.IsNullOrEmpty(config.PhoneColumnName))
                        cmbPhoneColumn.Text = config.PhoneColumnName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore caricamento configurazione: {ex.Message}", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiverConfigForm_Load(object sender, EventArgs e)
        {

        }
    }
}
