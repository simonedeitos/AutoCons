using AutoCons.Helpers;
using AutoCons.Models;
using AutoCons.Services;
using System.Text.Json;

namespace AutoCons.Forms
{
    public partial class SenderConfigForm : Form
    {
        private static readonly string ConfigPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config_sender.json");

        private List<string> _loadedNumbers = new();

        public SenderConfigForm()
        {
            InitializeComponent();
            PopulateDayCheckboxes();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadConfig();
        }

        private void PopulateDayCheckboxes()
        {
            flpDays.Controls.Clear();
            for (int day = 1; day <= 28; day++)
            {
                var chk = new CheckBox
                {
                    Text = day.ToString(),
                    Width = 50,
                    Tag = day
                };
                flpDays.Controls.Add(chk);
            }
        }

        private void btnBrowseNumbers_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title = "Seleziona file numeri di telefono",
                Filter = "File testo|*.txt;*.csv|Tutti i file|*.*"
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;

            txtNumbersFile.Text = dlg.FileName;
            LoadNumbersPreview(dlg.FileName);
        }

        private void LoadNumbersPreview(string filePath)
        {
            try
            {
                _loadedNumbers = CsvSmartReader.ReadPhoneNumbers(filePath)
                    .Select(PhoneNormalizer.Normalize)
                    .Where(n => !string.IsNullOrWhiteSpace(n))
                    .Distinct()
                    .ToList();

                dgvNumbers.DataSource = null;
                var dt = new System.Data.DataTable();
                dt.Columns.Add("Numero", typeof(string));
                foreach (var n in _loadedNumbers)
                    dt.Rows.Add(n);

                dgvNumbers.DataSource = dt;
                lblNumberCount.Text = $"Totale numeri: {_loadedNumbers.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore caricamento file: {ex.Message}", "Errore",
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
                SchedulerService.CreateOrUpdateSenderTask(
                    config.ScheduledDays,
                    config.MinTime,
                    config.MaxTime);
                MessageBox.Show("Task pianificato in Windows Task Scheduler.", "Pianificazione",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore pianificazione: {ex.Message}", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSendNow_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var config = BuildConfig();
            btnSendNow.Enabled = false;
            try
            {
                var service = new SenderService(config);
                await service.RunAsync();
                MessageBox.Show("Email inviata con successo.", "Invio completato",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore invio: {ex.Message}", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSendNow.Enabled = true;
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
            var sent = RegistryHelper.LoadAllValues("Sender\\SentNumbers");
            dgvHistory.DataSource = null;
            var dt = new System.Data.DataTable();
            dt.Columns.Add("Numero", typeof(string));
            dt.Columns.Add("Data Invio", typeof(string));

            foreach (var kv in sent.OrderByDescending(kv => kv.Value))
                dt.Rows.Add(kv.Key, kv.Value);

            dgvHistory.DataSource = dt;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtNumbersFile.Text))
            {
                MessageBox.Show("Selezionare il file dei numeri.", "Validazione",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (tpMinTime.Value.TimeOfDay >= tpMaxTime.Value.TimeOfDay)
            {
                MessageBox.Show("L'orario minimo deve essere inferiore all'orario massimo.",
                    "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSmtpServer.Text))
            {
                MessageBox.Show("Inserire il server SMTP.", "Validazione",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private SenderConfig BuildConfig()
        {
            var days = flpDays.Controls.OfType<CheckBox>()
                .Where(c => c.Checked)
                .Select(c => (int)c.Tag!)
                .ToList();

            return new SenderConfig
            {
                NumbersFilePath = txtNumbersFile.Text,
                ScheduledDays = days,
                MinTime = tpMinTime.Value.TimeOfDay,
                MaxTime = tpMaxTime.Value.TimeOfDay,
                NumbersPerEmail = (int)nudNumbersPerEmail.Value,
                SmtpServer = txtSmtpServer.Text,
                SmtpPort = (int)nudSmtpPort.Value,
                SmtpUseSsl = chkSmtpSsl.Checked,
                ImapServer = txtImapServer.Text,
                ImapPort = (int)nudImapPort.Value,
                ImapUseSsl = chkImapSsl.Checked,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                PasswordEncrypted = CryptoHelper.Encrypt(txtPassword.Text),
                SenderDisplayName = txtSenderDisplayName.Text,
                Recipients = txtRecipients.Text,
                Subject = txtSubject.Text,
                BodyTemplate = txtBodyTemplate.Text,
                SharedHmacKey = txtHmacKey.Text
            };
        }

        private void SaveConfig(SenderConfig config)
        {
            // Don't serialize plain password
            var toSave = new SenderConfig
            {
                NumbersFilePath = config.NumbersFilePath,
                ScheduledDays = config.ScheduledDays,
                MinTime = config.MinTime,
                MaxTime = config.MaxTime,
                NumbersPerEmail = config.NumbersPerEmail,
                SmtpServer = config.SmtpServer,
                SmtpPort = config.SmtpPort,
                SmtpUseSsl = config.SmtpUseSsl,
                ImapServer = config.ImapServer,
                ImapPort = config.ImapPort,
                ImapUseSsl = config.ImapUseSsl,
                Username = config.Username,
                PasswordEncrypted = config.PasswordEncrypted,
                SenderDisplayName = config.SenderDisplayName,
                Recipients = config.Recipients,
                Subject = config.Subject,
                BodyTemplate = config.BodyTemplate,
                SharedHmacKey = config.SharedHmacKey
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
                var config = JsonSerializer.Deserialize<SenderConfig>(json);
                if (config == null) return;

                txtNumbersFile.Text = config.NumbersFilePath;
                tpMinTime.Value = DateTime.Today.Add(config.MinTime);
                tpMaxTime.Value = DateTime.Today.Add(config.MaxTime);
                nudNumbersPerEmail.Value = Math.Clamp(config.NumbersPerEmail, 2, 50);
                txtSmtpServer.Text = config.SmtpServer;
                nudSmtpPort.Value = config.SmtpPort;
                chkSmtpSsl.Checked = config.SmtpUseSsl;
                txtImapServer.Text = config.ImapServer;
                nudImapPort.Value = config.ImapPort;
                chkImapSsl.Checked = config.ImapUseSsl;
                txtUsername.Text = config.Username;
                txtPassword.Text = CryptoHelper.Decrypt(config.PasswordEncrypted);
                txtSenderDisplayName.Text = config.SenderDisplayName;
                txtRecipients.Text = config.Recipients;
                txtSubject.Text = config.Subject;
                txtBodyTemplate.Text = config.BodyTemplate;
                txtHmacKey.Text = config.SharedHmacKey;

                // Restore day checkboxes
                foreach (CheckBox chk in flpDays.Controls.OfType<CheckBox>())
                    chk.Checked = config.ScheduledDays.Contains((int)chk.Tag!);

                // Reload numbers preview if file exists
                if (File.Exists(config.NumbersFilePath))
                    LoadNumbersPreview(config.NumbersFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore caricamento configurazione: {ex.Message}", "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
