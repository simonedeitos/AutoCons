namespace AutoCons.Forms
{
    partial class SenderConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenderConfigForm));
            tabControl = new TabControl();
            tabNumbers = new TabPage();
            grpNumbersFile = new GroupBox();
            lblNumbersFile = new Label();
            txtNumbersFile = new TextBox();
            btnBrowseNumbers = new Button();
            lblNumberCount = new Label();
            dgvNumbers = new DataGridView();
            tabSchedule = new TabPage();
            grpSchedule = new GroupBox();
            lblDays = new Label();
            flpDays = new FlowLayoutPanel();
            grpTimeRange = new GroupBox();
            lblMinTime = new Label();
            tpMinTime = new DateTimePicker();
            lblMaxTime = new Label();
            tpMaxTime = new DateTimePicker();
            grpNumbersPerEmail = new GroupBox();
            lblNumbersPerEmail = new Label();
            nudNumbersPerEmail = new NumericUpDown();
            tabEmail = new TabPage();
            grpSmtp = new GroupBox();
            lblSmtpServer = new Label();
            txtSmtpServer = new TextBox();
            lblSmtpPort = new Label();
            nudSmtpPort = new NumericUpDown();
            chkSmtpSsl = new CheckBox();
            grpImap = new GroupBox();
            lblImapServer = new Label();
            txtImapServer = new TextBox();
            lblImapPort = new Label();
            nudImapPort = new NumericUpDown();
            chkImapSsl = new CheckBox();
            grpCredentials = new GroupBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblSenderDisplayName = new Label();
            txtSenderDisplayName = new TextBox();
            grpMessage = new GroupBox();
            lblRecipients = new Label();
            txtRecipients = new TextBox();
            lblSubject = new Label();
            txtSubject = new TextBox();
            lblBodyTemplate = new Label();
            txtBodyTemplate = new TextBox();
            tabSecurity = new TabPage();
            grpSecurity = new GroupBox();
            lblHmacKey = new Label();
            txtHmacKey = new TextBox();
            pnlButtons = new Panel();
            btnSaveConfig = new Button();
            btnLoadConfig = new Button();
            btnSchedule = new Button();
            btnSendNow = new Button();
            btnViewHistory = new Button();
            pnlHistory = new Panel();
            lblHistory = new Label();
            dgvHistory = new DataGridView();
            tabControl.SuspendLayout();
            tabNumbers.SuspendLayout();
            grpNumbersFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNumbers).BeginInit();
            tabSchedule.SuspendLayout();
            grpSchedule.SuspendLayout();
            grpTimeRange.SuspendLayout();
            grpNumbersPerEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumbersPerEmail).BeginInit();
            tabEmail.SuspendLayout();
            grpSmtp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSmtpPort).BeginInit();
            grpImap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudImapPort).BeginInit();
            grpCredentials.SuspendLayout();
            grpMessage.SuspendLayout();
            tabSecurity.SuspendLayout();
            grpSecurity.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabNumbers);
            tabControl.Controls.Add(tabSchedule);
            tabControl.Controls.Add(tabEmail);
            tabControl.Controls.Add(tabSecurity);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(900, 416);
            tabControl.TabIndex = 0;
            // 
            // tabNumbers
            // 
            tabNumbers.Controls.Add(grpNumbersFile);
            tabNumbers.Location = new Point(4, 24);
            tabNumbers.Name = "tabNumbers";
            tabNumbers.Size = new Size(892, 388);
            tabNumbers.TabIndex = 0;
            tabNumbers.Text = "File Numeri";
            // 
            // grpNumbersFile
            // 
            grpNumbersFile.Controls.Add(lblNumbersFile);
            grpNumbersFile.Controls.Add(txtNumbersFile);
            grpNumbersFile.Controls.Add(btnBrowseNumbers);
            grpNumbersFile.Controls.Add(lblNumberCount);
            grpNumbersFile.Controls.Add(dgvNumbers);
            grpNumbersFile.Location = new Point(10, 10);
            grpNumbersFile.Name = "grpNumbersFile";
            grpNumbersFile.Size = new Size(870, 510);
            grpNumbersFile.TabIndex = 0;
            grpNumbersFile.TabStop = false;
            grpNumbersFile.Text = "File Numeri di Telefono";
            // 
            // lblNumbersFile
            // 
            lblNumbersFile.AutoSize = true;
            lblNumbersFile.Location = new Point(10, 25);
            lblNumbersFile.Name = "lblNumbersFile";
            lblNumbersFile.Size = new Size(69, 15);
            lblNumbersFile.TabIndex = 0;
            lblNumbersFile.Text = "File numeri:";
            // 
            // txtNumbersFile
            // 
            txtNumbersFile.Location = new Point(100, 22);
            txtNumbersFile.Name = "txtNumbersFile";
            txtNumbersFile.ReadOnly = true;
            txtNumbersFile.Size = new Size(650, 23);
            txtNumbersFile.TabIndex = 0;
            // 
            // btnBrowseNumbers
            // 
            btnBrowseNumbers.Location = new Point(760, 21);
            btnBrowseNumbers.Name = "btnBrowseNumbers";
            btnBrowseNumbers.Size = new Size(90, 25);
            btnBrowseNumbers.TabIndex = 1;
            btnBrowseNumbers.Text = "Sfoglia...";
            btnBrowseNumbers.Click += btnBrowseNumbers_Click;
            // 
            // lblNumberCount
            // 
            lblNumberCount.AutoSize = true;
            lblNumberCount.Location = new Point(10, 55);
            lblNumberCount.Name = "lblNumberCount";
            lblNumberCount.Size = new Size(91, 15);
            lblNumberCount.TabIndex = 2;
            lblNumberCount.Text = "Totale numeri: 0";
            // 
            // dgvNumbers
            // 
            dgvNumbers.AllowUserToAddRows = false;
            dgvNumbers.AllowUserToDeleteRows = false;
            dgvNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNumbers.Location = new Point(10, 80);
            dgvNumbers.Name = "dgvNumbers";
            dgvNumbers.ReadOnly = true;
            dgvNumbers.Size = new Size(845, 400);
            dgvNumbers.TabIndex = 1;
            // 
            // tabSchedule
            // 
            tabSchedule.Controls.Add(grpSchedule);
            tabSchedule.Controls.Add(grpTimeRange);
            tabSchedule.Controls.Add(grpNumbersPerEmail);
            tabSchedule.Location = new Point(4, 24);
            tabSchedule.Name = "tabSchedule";
            tabSchedule.Size = new Size(892, 532);
            tabSchedule.TabIndex = 1;
            tabSchedule.Text = "Schedulazione";
            // 
            // grpSchedule
            // 
            grpSchedule.Controls.Add(lblDays);
            grpSchedule.Controls.Add(flpDays);
            grpSchedule.Location = new Point(10, 10);
            grpSchedule.Name = "grpSchedule";
            grpSchedule.Size = new Size(870, 140);
            grpSchedule.TabIndex = 0;
            grpSchedule.TabStop = false;
            grpSchedule.Text = "Giorni del Mese (1-28)";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Location = new Point(10, 20);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(213, 15);
            lblDays.TabIndex = 0;
            lblDays.Text = "Seleziona i giorni in cui inviare le email:";
            // 
            // flpDays
            // 
            flpDays.Location = new Point(10, 40);
            flpDays.Name = "flpDays";
            flpDays.Size = new Size(850, 85);
            flpDays.TabIndex = 0;
            // 
            // grpTimeRange
            // 
            grpTimeRange.Controls.Add(lblMinTime);
            grpTimeRange.Controls.Add(tpMinTime);
            grpTimeRange.Controls.Add(lblMaxTime);
            grpTimeRange.Controls.Add(tpMaxTime);
            grpTimeRange.Location = new Point(10, 160);
            grpTimeRange.Name = "grpTimeRange";
            grpTimeRange.Size = new Size(400, 90);
            grpTimeRange.TabIndex = 1;
            grpTimeRange.TabStop = false;
            grpTimeRange.Text = "Range Orario";
            // 
            // lblMinTime
            // 
            lblMinTime.AutoSize = true;
            lblMinTime.Location = new Point(10, 28);
            lblMinTime.Name = "lblMinTime";
            lblMinTime.Size = new Size(88, 15);
            lblMinTime.TabIndex = 0;
            lblMinTime.Text = "Orario minimo:";
            // 
            // tpMinTime
            // 
            tpMinTime.Format = DateTimePickerFormat.Time;
            tpMinTime.Location = new Point(120, 25);
            tpMinTime.Name = "tpMinTime";
            tpMinTime.ShowUpDown = true;
            tpMinTime.Size = new Size(100, 23);
            tpMinTime.TabIndex = 1;
            tpMinTime.Value = new DateTime(2026, 4, 1, 8, 0, 0, 0);
            // 
            // lblMaxTime
            // 
            lblMaxTime.AutoSize = true;
            lblMaxTime.Location = new Point(10, 58);
            lblMaxTime.Name = "lblMaxTime";
            lblMaxTime.Size = new Size(94, 15);
            lblMaxTime.TabIndex = 2;
            lblMaxTime.Text = "Orario massimo:";
            // 
            // tpMaxTime
            // 
            tpMaxTime.Format = DateTimePickerFormat.Time;
            tpMaxTime.Location = new Point(120, 55);
            tpMaxTime.Name = "tpMaxTime";
            tpMaxTime.ShowUpDown = true;
            tpMaxTime.Size = new Size(100, 23);
            tpMaxTime.TabIndex = 3;
            tpMaxTime.Value = new DateTime(2026, 4, 1, 17, 0, 0, 0);
            // 
            // grpNumbersPerEmail
            // 
            grpNumbersPerEmail.Controls.Add(lblNumbersPerEmail);
            grpNumbersPerEmail.Controls.Add(nudNumbersPerEmail);
            grpNumbersPerEmail.Location = new Point(420, 160);
            grpNumbersPerEmail.Name = "grpNumbersPerEmail";
            grpNumbersPerEmail.Size = new Size(300, 90);
            grpNumbersPerEmail.TabIndex = 2;
            grpNumbersPerEmail.TabStop = false;
            grpNumbersPerEmail.Text = "Numeri per Email";
            // 
            // lblNumbersPerEmail
            // 
            lblNumbersPerEmail.AutoSize = true;
            lblNumbersPerEmail.Location = new Point(10, 35);
            lblNumbersPerEmail.Name = "lblNumbersPerEmail";
            lblNumbersPerEmail.Size = new Size(104, 15);
            lblNumbersPerEmail.TabIndex = 0;
            lblNumbersPerEmail.Text = "Numeri da inviare:";
            // 
            // nudNumbersPerEmail
            // 
            nudNumbersPerEmail.Location = new Point(130, 32);
            nudNumbersPerEmail.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudNumbersPerEmail.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudNumbersPerEmail.Name = "nudNumbersPerEmail";
            nudNumbersPerEmail.Size = new Size(80, 23);
            nudNumbersPerEmail.TabIndex = 1;
            nudNumbersPerEmail.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // tabEmail
            // 
            tabEmail.Controls.Add(grpSmtp);
            tabEmail.Controls.Add(grpImap);
            tabEmail.Controls.Add(grpCredentials);
            tabEmail.Controls.Add(grpMessage);
            tabEmail.Location = new Point(4, 24);
            tabEmail.Name = "tabEmail";
            tabEmail.Size = new Size(892, 532);
            tabEmail.TabIndex = 2;
            tabEmail.Text = "Email";
            // 
            // grpSmtp
            // 
            grpSmtp.Controls.Add(lblSmtpServer);
            grpSmtp.Controls.Add(txtSmtpServer);
            grpSmtp.Controls.Add(lblSmtpPort);
            grpSmtp.Controls.Add(nudSmtpPort);
            grpSmtp.Controls.Add(chkSmtpSsl);
            grpSmtp.Location = new Point(10, 10);
            grpSmtp.Name = "grpSmtp";
            grpSmtp.Size = new Size(420, 100);
            grpSmtp.TabIndex = 0;
            grpSmtp.TabStop = false;
            grpSmtp.Text = "Server SMTP (Invio)";
            // 
            // lblSmtpServer
            // 
            lblSmtpServer.AutoSize = true;
            lblSmtpServer.Location = new Point(10, 28);
            lblSmtpServer.Name = "lblSmtpServer";
            lblSmtpServer.Size = new Size(42, 15);
            lblSmtpServer.TabIndex = 0;
            lblSmtpServer.Text = "Server:";
            // 
            // txtSmtpServer
            // 
            txtSmtpServer.Location = new Point(70, 25);
            txtSmtpServer.Name = "txtSmtpServer";
            txtSmtpServer.Size = new Size(200, 23);
            txtSmtpServer.TabIndex = 1;
            // 
            // lblSmtpPort
            // 
            lblSmtpPort.AutoSize = true;
            lblSmtpPort.Location = new Point(280, 28);
            lblSmtpPort.Name = "lblSmtpPort";
            lblSmtpPort.Size = new Size(38, 15);
            lblSmtpPort.TabIndex = 2;
            lblSmtpPort.Text = "Porta:";
            // 
            // nudSmtpPort
            // 
            nudSmtpPort.Location = new Point(320, 25);
            nudSmtpPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudSmtpPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSmtpPort.Name = "nudSmtpPort";
            nudSmtpPort.Size = new Size(80, 23);
            nudSmtpPort.TabIndex = 3;
            nudSmtpPort.Value = new decimal(new int[] { 587, 0, 0, 0 });
            // 
            // chkSmtpSsl
            // 
            chkSmtpSsl.AutoSize = true;
            chkSmtpSsl.Checked = true;
            chkSmtpSsl.CheckState = CheckState.Checked;
            chkSmtpSsl.Location = new Point(10, 60);
            chkSmtpSsl.Name = "chkSmtpSsl";
            chkSmtpSsl.Size = new Size(89, 19);
            chkSmtpSsl.TabIndex = 4;
            chkSmtpSsl.Text = "Usa SSL/TLS";
            // 
            // grpImap
            // 
            grpImap.Controls.Add(lblImapServer);
            grpImap.Controls.Add(txtImapServer);
            grpImap.Controls.Add(lblImapPort);
            grpImap.Controls.Add(nudImapPort);
            grpImap.Controls.Add(chkImapSsl);
            grpImap.Location = new Point(440, 10);
            grpImap.Name = "grpImap";
            grpImap.Size = new Size(440, 100);
            grpImap.TabIndex = 1;
            grpImap.TabStop = false;
            grpImap.Text = "Server IMAP (Cartella Inviati)";
            // 
            // lblImapServer
            // 
            lblImapServer.AutoSize = true;
            lblImapServer.Location = new Point(10, 28);
            lblImapServer.Name = "lblImapServer";
            lblImapServer.Size = new Size(42, 15);
            lblImapServer.TabIndex = 0;
            lblImapServer.Text = "Server:";
            // 
            // txtImapServer
            // 
            txtImapServer.Location = new Point(70, 25);
            txtImapServer.Name = "txtImapServer";
            txtImapServer.Size = new Size(200, 23);
            txtImapServer.TabIndex = 1;
            // 
            // lblImapPort
            // 
            lblImapPort.AutoSize = true;
            lblImapPort.Location = new Point(280, 28);
            lblImapPort.Name = "lblImapPort";
            lblImapPort.Size = new Size(38, 15);
            lblImapPort.TabIndex = 2;
            lblImapPort.Text = "Porta:";
            // 
            // nudImapPort
            // 
            nudImapPort.Location = new Point(320, 25);
            nudImapPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudImapPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudImapPort.Name = "nudImapPort";
            nudImapPort.Size = new Size(80, 23);
            nudImapPort.TabIndex = 3;
            nudImapPort.Value = new decimal(new int[] { 993, 0, 0, 0 });
            // 
            // chkImapSsl
            // 
            chkImapSsl.AutoSize = true;
            chkImapSsl.Checked = true;
            chkImapSsl.CheckState = CheckState.Checked;
            chkImapSsl.Location = new Point(10, 60);
            chkImapSsl.Name = "chkImapSsl";
            chkImapSsl.Size = new Size(66, 19);
            chkImapSsl.TabIndex = 4;
            chkImapSsl.Text = "Usa SSL";
            // 
            // grpCredentials
            // 
            grpCredentials.Controls.Add(lblUsername);
            grpCredentials.Controls.Add(txtUsername);
            grpCredentials.Controls.Add(lblPassword);
            grpCredentials.Controls.Add(txtPassword);
            grpCredentials.Controls.Add(lblSenderDisplayName);
            grpCredentials.Controls.Add(txtSenderDisplayName);
            grpCredentials.Location = new Point(10, 120);
            grpCredentials.Name = "grpCredentials";
            grpCredentials.Size = new Size(870, 100);
            grpCredentials.TabIndex = 2;
            grpCredentials.TabStop = false;
            grpCredentials.Text = "Credenziali";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(10, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(80, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(230, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(330, 30);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(400, 27);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 3;
            // 
            // lblSenderDisplayName
            // 
            lblSenderDisplayName.AutoSize = true;
            lblSenderDisplayName.Location = new Point(10, 62);
            lblSenderDisplayName.Name = "lblSenderDisplayName";
            lblSenderDisplayName.Size = new Size(91, 15);
            lblSenderDisplayName.TabIndex = 4;
            lblSenderDisplayName.Text = "Nome mittente:";
            // 
            // txtSenderDisplayName
            // 
            txtSenderDisplayName.Location = new Point(110, 59);
            txtSenderDisplayName.Name = "txtSenderDisplayName";
            txtSenderDisplayName.Size = new Size(250, 23);
            txtSenderDisplayName.TabIndex = 5;
            // 
            // grpMessage
            // 
            grpMessage.Controls.Add(lblRecipients);
            grpMessage.Controls.Add(txtRecipients);
            grpMessage.Controls.Add(lblSubject);
            grpMessage.Controls.Add(txtSubject);
            grpMessage.Controls.Add(lblBodyTemplate);
            grpMessage.Controls.Add(txtBodyTemplate);
            grpMessage.Location = new Point(10, 230);
            grpMessage.Name = "grpMessage";
            grpMessage.Size = new Size(870, 290);
            grpMessage.TabIndex = 3;
            grpMessage.TabStop = false;
            grpMessage.Text = "Messaggio";
            // 
            // lblRecipients
            // 
            lblRecipients.AutoSize = true;
            lblRecipients.Location = new Point(10, 28);
            lblRecipients.Name = "lblRecipients";
            lblRecipients.Size = new Size(80, 15);
            lblRecipients.TabIndex = 0;
            lblRecipients.Text = "Destinatari (;):";
            // 
            // txtRecipients
            // 
            txtRecipients.Location = new Point(120, 25);
            txtRecipients.Name = "txtRecipients";
            txtRecipients.Size = new Size(730, 23);
            txtRecipients.TabIndex = 1;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(10, 60);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(54, 15);
            lblSubject.TabIndex = 2;
            lblSubject.Text = "Oggetto:";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(120, 57);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(730, 23);
            txtSubject.TabIndex = 3;
            // 
            // lblBodyTemplate
            // 
            lblBodyTemplate.AutoSize = true;
            lblBodyTemplate.Location = new Point(10, 92);
            lblBodyTemplate.Name = "lblBodyTemplate";
            lblBodyTemplate.Size = new Size(170, 15);
            lblBodyTemplate.TabIndex = 4;
            lblBodyTemplate.Text = "Corpo email (usa <numbers>):";
            // 
            // txtBodyTemplate
            // 
            txtBodyTemplate.Location = new Point(10, 115);
            txtBodyTemplate.Multiline = true;
            txtBodyTemplate.Name = "txtBodyTemplate";
            txtBodyTemplate.ScrollBars = ScrollBars.Vertical;
            txtBodyTemplate.Size = new Size(840, 155);
            txtBodyTemplate.TabIndex = 5;
            txtBodyTemplate.Text = "Gentile cliente,\r\n\r\ndi seguito i numeri di telefono da verificare:\r\n\r\n<numbers>\r\n\r\nCordiali saluti";
            // 
            // tabSecurity
            // 
            tabSecurity.Controls.Add(grpSecurity);
            tabSecurity.Location = new Point(4, 24);
            tabSecurity.Name = "tabSecurity";
            tabSecurity.Size = new Size(892, 532);
            tabSecurity.TabIndex = 3;
            tabSecurity.Text = "Sicurezza";
            // 
            // grpSecurity
            // 
            grpSecurity.Controls.Add(lblHmacKey);
            grpSecurity.Controls.Add(txtHmacKey);
            grpSecurity.Location = new Point(10, 10);
            grpSecurity.Name = "grpSecurity";
            grpSecurity.Size = new Size(870, 80);
            grpSecurity.TabIndex = 0;
            grpSecurity.TabStop = false;
            grpSecurity.Text = "Chiave HMAC Condivisa";
            // 
            // lblHmacKey
            // 
            lblHmacKey.AutoSize = true;
            lblHmacKey.Location = new Point(10, 30);
            lblHmacKey.Name = "lblHmacKey";
            lblHmacKey.Size = new Size(99, 15);
            lblHmacKey.TabIndex = 0;
            lblHmacKey.Text = "Chiave condivisa:";
            // 
            // txtHmacKey
            // 
            txtHmacKey.Location = new Point(130, 27);
            txtHmacKey.Name = "txtHmacKey";
            txtHmacKey.Size = new Size(400, 23);
            txtHmacKey.TabIndex = 1;
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnSaveConfig);
            pnlButtons.Controls.Add(btnLoadConfig);
            pnlButtons.Controls.Add(btnSchedule);
            pnlButtons.Controls.Add(btnSendNow);
            pnlButtons.Controls.Add(btnViewHistory);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 416);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(900, 45);
            pnlButtons.TabIndex = 1;
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.Location = new Point(10, 10);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(150, 28);
            btnSaveConfig.TabIndex = 0;
            btnSaveConfig.Text = "Salva Configurazione";
            btnSaveConfig.Click += btnSaveConfig_Click;
            // 
            // btnLoadConfig
            // 
            btnLoadConfig.Location = new Point(170, 10);
            btnLoadConfig.Name = "btnLoadConfig";
            btnLoadConfig.Size = new Size(150, 28);
            btnLoadConfig.TabIndex = 1;
            btnLoadConfig.Text = "Carica Configurazione";
            btnLoadConfig.Click += btnLoadConfig_Click;
            // 
            // btnSchedule
            // 
            btnSchedule.Location = new Point(330, 10);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(150, 28);
            btnSchedule.TabIndex = 2;
            btnSchedule.Text = "Pianifica in Windows";
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnSendNow
            // 
            btnSendNow.BackColor = Color.FromArgb(0, 120, 215);
            btnSendNow.ForeColor = Color.White;
            btnSendNow.Location = new Point(490, 10);
            btnSendNow.Name = "btnSendNow";
            btnSendNow.Size = new Size(100, 28);
            btnSendNow.TabIndex = 3;
            btnSendNow.Text = "Invia Ora";
            btnSendNow.UseVisualStyleBackColor = false;
            btnSendNow.Click += btnSendNow_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(600, 10);
            btnViewHistory.Name = "btnViewHistory";
            btnViewHistory.Size = new Size(130, 28);
            btnViewHistory.TabIndex = 4;
            btnViewHistory.Text = "Visualizza Storico";
            btnViewHistory.Click += btnViewHistory_Click;
            // 
            // pnlHistory
            // 
            pnlHistory.Controls.Add(lblHistory);
            pnlHistory.Controls.Add(dgvHistory);
            pnlHistory.Dock = DockStyle.Bottom;
            pnlHistory.Location = new Point(0, 461);
            pnlHistory.Name = "pnlHistory";
            pnlHistory.Size = new Size(900, 200);
            pnlHistory.TabIndex = 2;
            pnlHistory.Visible = false;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHistory.Location = new Point(5, 5);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(74, 15);
            lblHistory.TabIndex = 0;
            lblHistory.Text = "Storico Invii";
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.Location = new Point(5, 25);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.Size = new Size(885, 165);
            dgvHistory.TabIndex = 0;
            // 
            // SenderConfigForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 661);
            Controls.Add(tabControl);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHistory);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(916, 700);
            Name = "SenderConfigForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoCons - Configurazione Sender";
            tabControl.ResumeLayout(false);
            tabNumbers.ResumeLayout(false);
            grpNumbersFile.ResumeLayout(false);
            grpNumbersFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNumbers).EndInit();
            tabSchedule.ResumeLayout(false);
            grpSchedule.ResumeLayout(false);
            grpSchedule.PerformLayout();
            grpTimeRange.ResumeLayout(false);
            grpTimeRange.PerformLayout();
            grpNumbersPerEmail.ResumeLayout(false);
            grpNumbersPerEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudNumbersPerEmail).EndInit();
            tabEmail.ResumeLayout(false);
            grpSmtp.ResumeLayout(false);
            grpSmtp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSmtpPort).EndInit();
            grpImap.ResumeLayout(false);
            grpImap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudImapPort).EndInit();
            grpCredentials.ResumeLayout(false);
            grpCredentials.PerformLayout();
            grpMessage.ResumeLayout(false);
            grpMessage.PerformLayout();
            tabSecurity.ResumeLayout(false);
            grpSecurity.ResumeLayout(false);
            grpSecurity.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlHistory.ResumeLayout(false);
            pnlHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabNumbers;
        private TabPage tabSchedule;
        private TabPage tabEmail;
        private TabPage tabSecurity;

        private GroupBox grpNumbersFile;
        private Label lblNumbersFile;
        private TextBox txtNumbersFile;
        private Button btnBrowseNumbers;
        private Label lblNumberCount;
        private DataGridView dgvNumbers;

        private GroupBox grpSchedule;
        private Label lblDays;
        private FlowLayoutPanel flpDays;

        private GroupBox grpTimeRange;
        private Label lblMinTime;
        private DateTimePicker tpMinTime;
        private Label lblMaxTime;
        private DateTimePicker tpMaxTime;

        private GroupBox grpNumbersPerEmail;
        private Label lblNumbersPerEmail;
        private NumericUpDown nudNumbersPerEmail;

        private GroupBox grpSmtp;
        private Label lblSmtpServer;
        private TextBox txtSmtpServer;
        private Label lblSmtpPort;
        private NumericUpDown nudSmtpPort;
        private CheckBox chkSmtpSsl;

        private GroupBox grpImap;
        private Label lblImapServer;
        private TextBox txtImapServer;
        private Label lblImapPort;
        private NumericUpDown nudImapPort;
        private CheckBox chkImapSsl;

        private GroupBox grpCredentials;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblSenderDisplayName;
        private TextBox txtSenderDisplayName;

        private GroupBox grpMessage;
        private Label lblRecipients;
        private TextBox txtRecipients;
        private Label lblSubject;
        private TextBox txtSubject;
        private Label lblBodyTemplate;
        private TextBox txtBodyTemplate;

        private GroupBox grpSecurity;
        private Label lblHmacKey;
        private TextBox txtHmacKey;

        private Panel pnlButtons;
        private Button btnSaveConfig;
        private Button btnLoadConfig;
        private Button btnSchedule;
        private Button btnSendNow;
        private Button btnViewHistory;

        private Panel pnlHistory;
        private Label lblHistory;
        private DataGridView dgvHistory;
    }
}
