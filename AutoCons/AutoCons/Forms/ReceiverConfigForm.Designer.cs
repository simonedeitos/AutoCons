namespace AutoCons.Forms
{
    partial class ReceiverConfigForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            this.tabControl = new TabControl();
            this.tabImap = new TabPage();
            this.tabSmtp = new TabPage();
            this.tabCsv = new TabPage();
            this.tabReply = new TabPage();
            this.tabSecurity = new TabPage();

            // IMAP tab controls
            this.grpImap = new GroupBox();
            this.lblImapServer = new Label();
            this.txtImapServer = new TextBox();
            this.lblImapPort = new Label();
            this.nudImapPort = new NumericUpDown();
            this.chkImapSsl = new CheckBox();
            this.lblImapUsername = new Label();
            this.txtImapUsername = new TextBox();
            this.lblImapPassword = new Label();
            this.txtImapPassword = new TextBox();
            this.grpSchedule = new GroupBox();
            this.lblCheckTime = new Label();
            this.tpCheckTime = new DateTimePicker();
            this.grpMonitor = new GroupBox();
            this.lblMonitoredSender = new Label();
            this.txtMonitoredSender = new TextBox();

            // SMTP tab controls
            this.grpSmtp = new GroupBox();
            this.lblSmtpServer = new Label();
            this.txtSmtpServer = new TextBox();
            this.lblSmtpPort = new Label();
            this.nudSmtpPort = new NumericUpDown();
            this.chkSmtpSsl = new CheckBox();
            this.lblSmtpUsername = new Label();
            this.txtSmtpUsername = new TextBox();
            this.lblSmtpPassword = new Label();
            this.txtSmtpPassword = new TextBox();
            this.lblSenderDisplayName = new Label();
            this.txtSenderDisplayName = new TextBox();
            this.grpSentImap = new GroupBox();
            this.lblSentImapServer = new Label();
            this.txtSentImapServer = new TextBox();
            this.lblSentImapPort = new Label();
            this.nudSentImapPort = new NumericUpDown();
            this.chkSentImapSsl = new CheckBox();

            // CSV tab controls
            this.grpCsvFile = new GroupBox();
            this.lblCsvFile = new Label();
            this.txtCsvFile = new TextBox();
            this.btnBrowseCsv = new Button();
            this.lblPhoneColumn = new Label();
            this.cmbPhoneColumn = new ComboBox();
            this.lblCsvInfo = new Label();
            this.dgvCsvPreview = new DataGridView();

            // Reply tab controls
            this.grpReply = new GroupBox();
            this.lblReplyTemplate = new Label();
            this.txtReplyTemplate = new TextBox();

            // Security tab controls
            this.grpSecurity = new GroupBox();
            this.lblHmacKey = new Label();
            this.txtHmacKey = new TextBox();

            // Buttons and history
            this.pnlButtons = new Panel();
            this.btnSaveConfig = new Button();
            this.btnLoadConfig = new Button();
            this.btnSchedule = new Button();
            this.btnCheckNow = new Button();
            this.btnViewHistory = new Button();

            this.pnlHistory = new Panel();
            this.lblHistory = new Label();
            this.dgvHistory = new DataGridView();

            this.tabControl.SuspendLayout();
            this.tabImap.SuspendLayout();
            this.tabSmtp.SuspendLayout();
            this.tabCsv.SuspendLayout();
            this.tabReply.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.grpImap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudImapPort).BeginInit();
            this.grpSchedule.SuspendLayout();
            this.grpMonitor.SuspendLayout();
            this.grpSmtp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudSmtpPort).BeginInit();
            this.grpSentImap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudSentImapPort).BeginInit();
            this.grpCsvFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvCsvPreview).BeginInit();
            this.grpReply.SuspendLayout();
            this.grpSecurity.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvHistory).BeginInit();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(this.tabImap);
            this.tabControl.Controls.Add(this.tabSmtp);
            this.tabControl.Controls.Add(this.tabCsv);
            this.tabControl.Controls.Add(this.tabReply);
            this.tabControl.Controls.Add(this.tabSecurity);
            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(900, 560);
            this.tabControl.TabIndex = 0;

            // === TAB IMAP ===
            this.tabImap.Controls.Add(this.grpImap);
            this.tabImap.Controls.Add(this.grpMonitor);
            this.tabImap.Controls.Add(this.grpSchedule);
            this.tabImap.Location = new Point(4, 24);
            this.tabImap.Name = "tabImap";
            this.tabImap.Size = new Size(892, 532);
            this.tabImap.Text = "IMAP Ricezione";

            // grpImap
            this.grpImap.Controls.Add(this.lblImapServer);
            this.grpImap.Controls.Add(this.txtImapServer);
            this.grpImap.Controls.Add(this.lblImapPort);
            this.grpImap.Controls.Add(this.nudImapPort);
            this.grpImap.Controls.Add(this.chkImapSsl);
            this.grpImap.Controls.Add(this.lblImapUsername);
            this.grpImap.Controls.Add(this.txtImapUsername);
            this.grpImap.Controls.Add(this.lblImapPassword);
            this.grpImap.Controls.Add(this.txtImapPassword);
            this.grpImap.Location = new Point(10, 10);
            this.grpImap.Name = "grpImap";
            this.grpImap.Size = new Size(870, 140);
            this.grpImap.Text = "Server IMAP (Ricezione Email)";
            this.grpImap.TabIndex = 0;

            // lblImapServer
            this.lblImapServer.AutoSize = true;
            this.lblImapServer.Location = new Point(10, 28);
            this.lblImapServer.Text = "Server:";

            // txtImapServer
            this.txtImapServer.Location = new Point(80, 25);
            this.txtImapServer.Name = "txtImapServer";
            this.txtImapServer.Size = new Size(230, 23);

            // lblImapPort
            this.lblImapPort.AutoSize = true;
            this.lblImapPort.Location = new Point(325, 28);
            this.lblImapPort.Text = "Porta:";

            // nudImapPort
            this.nudImapPort.Location = new Point(370, 25);
            this.nudImapPort.Maximum = 65535;
            this.nudImapPort.Minimum = 1;
            this.nudImapPort.Value = 993;
            this.nudImapPort.Name = "nudImapPort";
            this.nudImapPort.Size = new Size(80, 23);

            // chkImapSsl
            this.chkImapSsl.AutoSize = true;
            this.chkImapSsl.Checked = true;
            this.chkImapSsl.Location = new Point(460, 27);
            this.chkImapSsl.Name = "chkImapSsl";
            this.chkImapSsl.Text = "Usa SSL";

            // lblImapUsername
            this.lblImapUsername.AutoSize = true;
            this.lblImapUsername.Location = new Point(10, 62);
            this.lblImapUsername.Text = "Username:";

            // txtImapUsername
            this.txtImapUsername.Location = new Point(80, 59);
            this.txtImapUsername.Name = "txtImapUsername";
            this.txtImapUsername.Size = new Size(230, 23);

            // lblImapPassword
            this.lblImapPassword.AutoSize = true;
            this.lblImapPassword.Location = new Point(10, 96);
            this.lblImapPassword.Text = "Password:";

            // txtImapPassword
            this.txtImapPassword.Location = new Point(80, 93);
            this.txtImapPassword.Name = "txtImapPassword";
            this.txtImapPassword.PasswordChar = '●';
            this.txtImapPassword.Size = new Size(230, 23);

            // grpMonitor
            this.grpMonitor.Controls.Add(this.lblMonitoredSender);
            this.grpMonitor.Controls.Add(this.txtMonitoredSender);
            this.grpMonitor.Location = new Point(10, 160);
            this.grpMonitor.Name = "grpMonitor";
            this.grpMonitor.Size = new Size(870, 70);
            this.grpMonitor.Text = "Filtro Mittente";
            this.grpMonitor.TabIndex = 1;

            // lblMonitoredSender
            this.lblMonitoredSender.AutoSize = true;
            this.lblMonitoredSender.Location = new Point(10, 30);
            this.lblMonitoredSender.Text = "Email mittente monitorato:";

            // txtMonitoredSender
            this.txtMonitoredSender.Location = new Point(185, 27);
            this.txtMonitoredSender.Name = "txtMonitoredSender";
            this.txtMonitoredSender.Size = new Size(300, 23);

            // grpSchedule
            this.grpSchedule.Controls.Add(this.lblCheckTime);
            this.grpSchedule.Controls.Add(this.tpCheckTime);
            this.grpSchedule.Location = new Point(10, 240);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new Size(870, 70);
            this.grpSchedule.Text = "Schedulazione Giornaliera";
            this.grpSchedule.TabIndex = 2;

            // lblCheckTime
            this.lblCheckTime.AutoSize = true;
            this.lblCheckTime.Location = new Point(10, 30);
            this.lblCheckTime.Text = "Orario controllo giornaliero:";

            // tpCheckTime
            this.tpCheckTime.Format = DateTimePickerFormat.Time;
            this.tpCheckTime.Location = new Point(200, 27);
            this.tpCheckTime.Name = "tpCheckTime";
            this.tpCheckTime.ShowUpDown = true;
            this.tpCheckTime.Size = new Size(100, 23);
            this.tpCheckTime.Value = DateTime.Today.AddHours(18).AddMinutes(15);

            // === TAB SMTP ===
            this.tabSmtp.Controls.Add(this.grpSmtp);
            this.tabSmtp.Controls.Add(this.grpSentImap);
            this.tabSmtp.Location = new Point(4, 24);
            this.tabSmtp.Name = "tabSmtp";
            this.tabSmtp.Size = new Size(892, 532);
            this.tabSmtp.Text = "SMTP Risposta";

            // grpSmtp
            this.grpSmtp.Controls.Add(this.lblSmtpServer);
            this.grpSmtp.Controls.Add(this.txtSmtpServer);
            this.grpSmtp.Controls.Add(this.lblSmtpPort);
            this.grpSmtp.Controls.Add(this.nudSmtpPort);
            this.grpSmtp.Controls.Add(this.chkSmtpSsl);
            this.grpSmtp.Controls.Add(this.lblSmtpUsername);
            this.grpSmtp.Controls.Add(this.txtSmtpUsername);
            this.grpSmtp.Controls.Add(this.lblSmtpPassword);
            this.grpSmtp.Controls.Add(this.txtSmtpPassword);
            this.grpSmtp.Controls.Add(this.lblSenderDisplayName);
            this.grpSmtp.Controls.Add(this.txtSenderDisplayName);
            this.grpSmtp.Location = new Point(10, 10);
            this.grpSmtp.Name = "grpSmtp";
            this.grpSmtp.Size = new Size(870, 170);
            this.grpSmtp.Text = "Server SMTP (Invio Risposta)";
            this.grpSmtp.TabIndex = 0;

            // lblSmtpServer
            this.lblSmtpServer.AutoSize = true;
            this.lblSmtpServer.Location = new Point(10, 28);
            this.lblSmtpServer.Text = "Server:";

            // txtSmtpServer
            this.txtSmtpServer.Location = new Point(80, 25);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new Size(230, 23);

            // lblSmtpPort
            this.lblSmtpPort.AutoSize = true;
            this.lblSmtpPort.Location = new Point(325, 28);
            this.lblSmtpPort.Text = "Porta:";

            // nudSmtpPort
            this.nudSmtpPort.Location = new Point(370, 25);
            this.nudSmtpPort.Maximum = 65535;
            this.nudSmtpPort.Minimum = 1;
            this.nudSmtpPort.Value = 587;
            this.nudSmtpPort.Name = "nudSmtpPort";
            this.nudSmtpPort.Size = new Size(80, 23);

            // chkSmtpSsl
            this.chkSmtpSsl.AutoSize = true;
            this.chkSmtpSsl.Checked = true;
            this.chkSmtpSsl.Location = new Point(460, 27);
            this.chkSmtpSsl.Name = "chkSmtpSsl";
            this.chkSmtpSsl.Text = "Usa SSL/TLS";

            // lblSmtpUsername
            this.lblSmtpUsername.AutoSize = true;
            this.lblSmtpUsername.Location = new Point(10, 62);
            this.lblSmtpUsername.Text = "Username:";

            // txtSmtpUsername
            this.txtSmtpUsername.Location = new Point(80, 59);
            this.txtSmtpUsername.Name = "txtSmtpUsername";
            this.txtSmtpUsername.Size = new Size(230, 23);

            // lblSmtpPassword
            this.lblSmtpPassword.AutoSize = true;
            this.lblSmtpPassword.Location = new Point(10, 96);
            this.lblSmtpPassword.Text = "Password:";

            // txtSmtpPassword
            this.txtSmtpPassword.Location = new Point(80, 93);
            this.txtSmtpPassword.Name = "txtSmtpPassword";
            this.txtSmtpPassword.PasswordChar = '●';
            this.txtSmtpPassword.Size = new Size(230, 23);

            // lblSenderDisplayName
            this.lblSenderDisplayName.AutoSize = true;
            this.lblSenderDisplayName.Location = new Point(10, 130);
            this.lblSenderDisplayName.Text = "Nome mittente:";

            // txtSenderDisplayName
            this.txtSenderDisplayName.Location = new Point(110, 127);
            this.txtSenderDisplayName.Name = "txtSenderDisplayName";
            this.txtSenderDisplayName.Size = new Size(250, 23);

            // grpSentImap
            this.grpSentImap.Controls.Add(this.lblSentImapServer);
            this.grpSentImap.Controls.Add(this.txtSentImapServer);
            this.grpSentImap.Controls.Add(this.lblSentImapPort);
            this.grpSentImap.Controls.Add(this.nudSentImapPort);
            this.grpSentImap.Controls.Add(this.chkSentImapSsl);
            this.grpSentImap.Location = new Point(10, 190);
            this.grpSentImap.Name = "grpSentImap";
            this.grpSentImap.Size = new Size(870, 80);
            this.grpSentImap.Text = "IMAP per Salvataggio Risposte Inviate";
            this.grpSentImap.TabIndex = 1;

            // lblSentImapServer
            this.lblSentImapServer.AutoSize = true;
            this.lblSentImapServer.Location = new Point(10, 30);
            this.lblSentImapServer.Text = "Server:";

            // txtSentImapServer
            this.txtSentImapServer.Location = new Point(80, 27);
            this.txtSentImapServer.Name = "txtSentImapServer";
            this.txtSentImapServer.Size = new Size(230, 23);

            // lblSentImapPort
            this.lblSentImapPort.AutoSize = true;
            this.lblSentImapPort.Location = new Point(325, 30);
            this.lblSentImapPort.Text = "Porta:";

            // nudSentImapPort
            this.nudSentImapPort.Location = new Point(370, 27);
            this.nudSentImapPort.Maximum = 65535;
            this.nudSentImapPort.Minimum = 1;
            this.nudSentImapPort.Value = 993;
            this.nudSentImapPort.Name = "nudSentImapPort";
            this.nudSentImapPort.Size = new Size(80, 23);

            // chkSentImapSsl
            this.chkSentImapSsl.AutoSize = true;
            this.chkSentImapSsl.Checked = true;
            this.chkSentImapSsl.Location = new Point(460, 30);
            this.chkSentImapSsl.Name = "chkSentImapSsl";
            this.chkSentImapSsl.Text = "Usa SSL";

            // === TAB CSV ===
            this.tabCsv.Controls.Add(this.grpCsvFile);
            this.tabCsv.Location = new Point(4, 24);
            this.tabCsv.Name = "tabCsv";
            this.tabCsv.Size = new Size(892, 532);
            this.tabCsv.Text = "File CSV Consensi";

            // grpCsvFile
            this.grpCsvFile.Controls.Add(this.lblCsvFile);
            this.grpCsvFile.Controls.Add(this.txtCsvFile);
            this.grpCsvFile.Controls.Add(this.btnBrowseCsv);
            this.grpCsvFile.Controls.Add(this.lblPhoneColumn);
            this.grpCsvFile.Controls.Add(this.cmbPhoneColumn);
            this.grpCsvFile.Controls.Add(this.lblCsvInfo);
            this.grpCsvFile.Controls.Add(this.dgvCsvPreview);
            this.grpCsvFile.Location = new Point(10, 10);
            this.grpCsvFile.Name = "grpCsvFile";
            this.grpCsvFile.Size = new Size(870, 510);
            this.grpCsvFile.Text = "File CSV Consensi";
            this.grpCsvFile.TabIndex = 0;

            // lblCsvFile
            this.lblCsvFile.AutoSize = true;
            this.lblCsvFile.Location = new Point(10, 25);
            this.lblCsvFile.Text = "File CSV:";

            // txtCsvFile
            this.txtCsvFile.Location = new Point(80, 22);
            this.txtCsvFile.Name = "txtCsvFile";
            this.txtCsvFile.ReadOnly = true;
            this.txtCsvFile.Size = new Size(650, 23);

            // btnBrowseCsv
            this.btnBrowseCsv.Location = new Point(740, 21);
            this.btnBrowseCsv.Name = "btnBrowseCsv";
            this.btnBrowseCsv.Size = new Size(90, 25);
            this.btnBrowseCsv.Text = "Sfoglia...";
            this.btnBrowseCsv.Click += new EventHandler(this.btnBrowseCsv_Click);

            // lblPhoneColumn
            this.lblPhoneColumn.AutoSize = true;
            this.lblPhoneColumn.Location = new Point(10, 58);
            this.lblPhoneColumn.Text = "Colonna numeri:";

            // cmbPhoneColumn
            this.cmbPhoneColumn.DropDownStyle = ComboBoxStyle.DropDown;
            this.cmbPhoneColumn.Location = new Point(120, 55);
            this.cmbPhoneColumn.Name = "cmbPhoneColumn";
            this.cmbPhoneColumn.Size = new Size(200, 23);

            // lblCsvInfo
            this.lblCsvInfo.AutoSize = true;
            this.lblCsvInfo.Location = new Point(10, 90);
            this.lblCsvInfo.Name = "lblCsvInfo";
            this.lblCsvInfo.Text = "Carica un file per vedere le informazioni";

            // dgvCsvPreview
            this.dgvCsvPreview.AllowUserToAddRows = false;
            this.dgvCsvPreview.AllowUserToDeleteRows = false;
            this.dgvCsvPreview.Location = new Point(10, 115);
            this.dgvCsvPreview.Name = "dgvCsvPreview";
            this.dgvCsvPreview.ReadOnly = true;
            this.dgvCsvPreview.Size = new Size(845, 380);
            this.dgvCsvPreview.TabIndex = 1;
            this.dgvCsvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // === TAB REPLY ===
            this.tabReply.Controls.Add(this.grpReply);
            this.tabReply.Location = new Point(4, 24);
            this.tabReply.Name = "tabReply";
            this.tabReply.Size = new Size(892, 532);
            this.tabReply.Text = "Risposta";

            // grpReply
            this.grpReply.Controls.Add(this.lblReplyTemplate);
            this.grpReply.Controls.Add(this.txtReplyTemplate);
            this.grpReply.Location = new Point(10, 10);
            this.grpReply.Name = "grpReply";
            this.grpReply.Size = new Size(870, 510);
            this.grpReply.Text = "Template Risposta";
            this.grpReply.TabIndex = 0;

            // lblReplyTemplate
            this.lblReplyTemplate.AutoSize = true;
            this.lblReplyTemplate.Location = new Point(10, 25);
            this.lblReplyTemplate.Text = "Template del messaggio di risposta (usa <notfound>...</notfound> per i numeri non trovati, {numbers} come segnaposto):";

            // txtReplyTemplate
            this.txtReplyTemplate.Location = new Point(10, 50);
            this.txtReplyTemplate.Multiline = true;
            this.txtReplyTemplate.Name = "txtReplyTemplate";
            this.txtReplyTemplate.ScrollBars = ScrollBars.Vertical;
            this.txtReplyTemplate.Size = new Size(840, 440);
            this.txtReplyTemplate.Text = "Gentile mittente,\r\n\r\nIn riscontro alla Sua richiesta, in allegato troverà il file CSV con i numeri verificati.\r\n\r\n<notfound>Si precisa inoltre che dei numeri verificati, i seguenti: {numbers} non risultano essere numeri in nostro possesso.</notfound>\r\n\r\nCordiali saluti.";

            // === TAB SECURITY ===
            this.tabSecurity.Controls.Add(this.grpSecurity);
            this.tabSecurity.Location = new Point(4, 24);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.Size = new Size(892, 532);
            this.tabSecurity.Text = "Sicurezza";

            // grpSecurity
            this.grpSecurity.Controls.Add(this.lblHmacKey);
            this.grpSecurity.Controls.Add(this.txtHmacKey);
            this.grpSecurity.Location = new Point(10, 10);
            this.grpSecurity.Name = "grpSecurity";
            this.grpSecurity.Size = new Size(870, 80);
            this.grpSecurity.Text = "Chiave HMAC Condivisa";
            this.grpSecurity.TabIndex = 0;

            // lblHmacKey
            this.lblHmacKey.AutoSize = true;
            this.lblHmacKey.Location = new Point(10, 30);
            this.lblHmacKey.Text = "Chiave condivisa:";

            // txtHmacKey
            this.txtHmacKey.Location = new Point(130, 27);
            this.txtHmacKey.Name = "txtHmacKey";
            this.txtHmacKey.Size = new Size(400, 23);

            // === BUTTONS PANEL ===
            this.pnlButtons.Controls.Add(this.btnSaveConfig);
            this.pnlButtons.Controls.Add(this.btnLoadConfig);
            this.pnlButtons.Controls.Add(this.btnSchedule);
            this.pnlButtons.Controls.Add(this.btnCheckNow);
            this.pnlButtons.Controls.Add(this.btnViewHistory);
            this.pnlButtons.Dock = DockStyle.Bottom;
            this.pnlButtons.Location = new Point(0, 560);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new Size(900, 45);
            this.pnlButtons.TabIndex = 1;

            // btnSaveConfig
            this.btnSaveConfig.Location = new Point(10, 10);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new Size(150, 28);
            this.btnSaveConfig.Text = "Salva Configurazione";
            this.btnSaveConfig.Click += new EventHandler(this.btnSaveConfig_Click);

            // btnLoadConfig
            this.btnLoadConfig.Location = new Point(170, 10);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new Size(150, 28);
            this.btnLoadConfig.Text = "Carica Configurazione";
            this.btnLoadConfig.Click += new EventHandler(this.btnLoadConfig_Click);

            // btnSchedule
            this.btnSchedule.Location = new Point(330, 10);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new Size(150, 28);
            this.btnSchedule.Text = "Pianifica in Windows";
            this.btnSchedule.Click += new EventHandler(this.btnSchedule_Click);

            // btnCheckNow
            this.btnCheckNow.Location = new Point(490, 10);
            this.btnCheckNow.Name = "btnCheckNow";
            this.btnCheckNow.Size = new Size(110, 28);
            this.btnCheckNow.Text = "Controlla Ora";
            this.btnCheckNow.BackColor = Color.FromArgb(0, 160, 80);
            this.btnCheckNow.ForeColor = Color.White;
            this.btnCheckNow.Click += new EventHandler(this.btnCheckNow_Click);

            // btnViewHistory
            this.btnViewHistory.Location = new Point(610, 10);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new Size(130, 28);
            this.btnViewHistory.Text = "Visualizza Storico";
            this.btnViewHistory.Click += new EventHandler(this.btnViewHistory_Click);

            // === HISTORY PANEL ===
            this.pnlHistory.Controls.Add(this.lblHistory);
            this.pnlHistory.Controls.Add(this.dgvHistory);
            this.pnlHistory.Dock = DockStyle.Bottom;
            this.pnlHistory.Location = new Point(0, 605);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new Size(900, 200);
            this.pnlHistory.Visible = false;
            this.pnlHistory.TabIndex = 2;

            // lblHistory
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblHistory.Location = new Point(5, 5);
            this.lblHistory.Text = "Storico Elaborazioni";

            // dgvHistory
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.Location = new Point(5, 25);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new Size(885, 165);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ReceiverConfigForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(900, 650);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHistory);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(916, 700);
            this.Name = "ReceiverConfigForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "AutoCons - Configurazione Receiver";

            this.tabControl.ResumeLayout(false);
            this.tabImap.ResumeLayout(false);
            this.tabSmtp.ResumeLayout(false);
            this.tabCsv.ResumeLayout(false);
            this.tabReply.ResumeLayout(false);
            this.tabSecurity.ResumeLayout(false);
            this.grpImap.ResumeLayout(false);
            this.grpImap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudImapPort).EndInit();
            this.grpSchedule.ResumeLayout(false);
            this.grpSchedule.PerformLayout();
            this.grpMonitor.ResumeLayout(false);
            this.grpMonitor.PerformLayout();
            this.grpSmtp.ResumeLayout(false);
            this.grpSmtp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudSmtpPort).EndInit();
            this.grpSentImap.ResumeLayout(false);
            this.grpSentImap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudSentImapPort).EndInit();
            this.grpCsvFile.ResumeLayout(false);
            this.grpCsvFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvCsvPreview).EndInit();
            this.grpReply.ResumeLayout(false);
            this.grpReply.PerformLayout();
            this.grpSecurity.ResumeLayout(false);
            this.grpSecurity.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.pnlHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvHistory).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabImap;
        private TabPage tabSmtp;
        private TabPage tabCsv;
        private TabPage tabReply;
        private TabPage tabSecurity;

        private GroupBox grpImap;
        private Label lblImapServer;
        private TextBox txtImapServer;
        private Label lblImapPort;
        private NumericUpDown nudImapPort;
        private CheckBox chkImapSsl;
        private Label lblImapUsername;
        private TextBox txtImapUsername;
        private Label lblImapPassword;
        private TextBox txtImapPassword;

        private GroupBox grpMonitor;
        private Label lblMonitoredSender;
        private TextBox txtMonitoredSender;

        private GroupBox grpSchedule;
        private Label lblCheckTime;
        private DateTimePicker tpCheckTime;

        private GroupBox grpSmtp;
        private Label lblSmtpServer;
        private TextBox txtSmtpServer;
        private Label lblSmtpPort;
        private NumericUpDown nudSmtpPort;
        private CheckBox chkSmtpSsl;
        private Label lblSmtpUsername;
        private TextBox txtSmtpUsername;
        private Label lblSmtpPassword;
        private TextBox txtSmtpPassword;
        private Label lblSenderDisplayName;
        private TextBox txtSenderDisplayName;

        private GroupBox grpSentImap;
        private Label lblSentImapServer;
        private TextBox txtSentImapServer;
        private Label lblSentImapPort;
        private NumericUpDown nudSentImapPort;
        private CheckBox chkSentImapSsl;

        private GroupBox grpCsvFile;
        private Label lblCsvFile;
        private TextBox txtCsvFile;
        private Button btnBrowseCsv;
        private Label lblPhoneColumn;
        private ComboBox cmbPhoneColumn;
        private Label lblCsvInfo;
        private DataGridView dgvCsvPreview;

        private GroupBox grpReply;
        private Label lblReplyTemplate;
        private TextBox txtReplyTemplate;

        private GroupBox grpSecurity;
        private Label lblHmacKey;
        private TextBox txtHmacKey;

        private Panel pnlButtons;
        private Button btnSaveConfig;
        private Button btnLoadConfig;
        private Button btnSchedule;
        private Button btnCheckNow;
        private Button btnViewHistory;

        private Panel pnlHistory;
        private Label lblHistory;
        private DataGridView dgvHistory;
    }
}
