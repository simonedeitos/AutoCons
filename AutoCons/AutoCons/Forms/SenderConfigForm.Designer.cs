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
            components = new System.ComponentModel.Container();

            this.tabControl = new TabControl();
            this.tabNumbers = new TabPage();
            this.tabSchedule = new TabPage();
            this.tabEmail = new TabPage();
            this.tabSecurity = new TabPage();

            // --- Tab Numbers ---
            this.grpNumbersFile = new GroupBox();
            this.lblNumberCount = new Label();
            this.btnBrowseNumbers = new Button();
            this.txtNumbersFile = new TextBox();
            this.lblNumbersFile = new Label();
            this.dgvNumbers = new DataGridView();

            // --- Tab Schedule ---
            this.grpSchedule = new GroupBox();
            this.flpDays = new FlowLayoutPanel();
            this.lblDays = new Label();
            this.grpTimeRange = new GroupBox();
            this.tpMaxTime = new DateTimePicker();
            this.lblMaxTime = new Label();
            this.tpMinTime = new DateTimePicker();
            this.lblMinTime = new Label();
            this.grpNumbersPerEmail = new GroupBox();
            this.nudNumbersPerEmail = new NumericUpDown();
            this.lblNumbersPerEmail = new Label();

            // --- Tab Email ---
            this.grpSmtp = new GroupBox();
            this.chkSmtpSsl = new CheckBox();
            this.nudSmtpPort = new NumericUpDown();
            this.lblSmtpPort = new Label();
            this.txtSmtpServer = new TextBox();
            this.lblSmtpServer = new Label();
            this.grpImap = new GroupBox();
            this.chkImapSsl = new CheckBox();
            this.nudImapPort = new NumericUpDown();
            this.lblImapPort = new Label();
            this.txtImapServer = new TextBox();
            this.lblImapServer = new Label();
            this.grpCredentials = new GroupBox();
            this.txtSenderDisplayName = new TextBox();
            this.lblSenderDisplayName = new Label();
            this.txtPassword = new TextBox();
            this.lblPassword = new Label();
            this.txtUsername = new TextBox();
            this.lblUsername = new Label();
            this.grpMessage = new GroupBox();
            this.txtBodyTemplate = new TextBox();
            this.lblBodyTemplate = new Label();
            this.txtSubject = new TextBox();
            this.lblSubject = new Label();
            this.txtRecipients = new TextBox();
            this.lblRecipients = new Label();

            // --- Tab Security ---
            this.grpSecurity = new GroupBox();
            this.txtHmacKey = new TextBox();
            this.lblHmacKey = new Label();

            // --- Buttons ---
            this.pnlButtons = new Panel();
            this.btnViewHistory = new Button();
            this.btnSendNow = new Button();
            this.btnSchedule = new Button();
            this.btnLoadConfig = new Button();
            this.btnSaveConfig = new Button();

            // --- History panel ---
            this.pnlHistory = new Panel();
            this.dgvHistory = new DataGridView();
            this.lblHistory = new Label();

            this.tabControl.SuspendLayout();
            this.tabNumbers.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.tabSecurity.SuspendLayout();
            this.grpNumbersFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvNumbers).BeginInit();
            this.grpSchedule.SuspendLayout();
            this.grpTimeRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudNumbersPerEmail).BeginInit();
            this.grpSmtp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudSmtpPort).BeginInit();
            this.grpImap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudImapPort).BeginInit();
            this.grpCredentials.SuspendLayout();
            this.grpMessage.SuspendLayout();
            this.grpSecurity.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvHistory).BeginInit();
            this.SuspendLayout();

            // tabControl
            this.tabControl.Controls.Add(this.tabNumbers);
            this.tabControl.Controls.Add(this.tabSchedule);
            this.tabControl.Controls.Add(this.tabEmail);
            this.tabControl.Controls.Add(this.tabSecurity);
            this.tabControl.Dock = DockStyle.Fill;
            this.tabControl.Location = new Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(900, 560);
            this.tabControl.TabIndex = 0;

            // tabNumbers
            this.tabNumbers.Controls.Add(this.grpNumbersFile);
            this.tabNumbers.Location = new Point(4, 24);
            this.tabNumbers.Name = "tabNumbers";
            this.tabNumbers.Size = new Size(892, 532);
            this.tabNumbers.Text = "File Numeri";

            // grpNumbersFile
            this.grpNumbersFile.Controls.Add(this.lblNumbersFile);
            this.grpNumbersFile.Controls.Add(this.txtNumbersFile);
            this.grpNumbersFile.Controls.Add(this.btnBrowseNumbers);
            this.grpNumbersFile.Controls.Add(this.lblNumberCount);
            this.grpNumbersFile.Controls.Add(this.dgvNumbers);
            this.grpNumbersFile.Location = new Point(10, 10);
            this.grpNumbersFile.Name = "grpNumbersFile";
            this.grpNumbersFile.Size = new Size(870, 510);
            this.grpNumbersFile.Text = "File Numeri di Telefono";
            this.grpNumbersFile.TabIndex = 0;

            // lblNumbersFile
            this.lblNumbersFile.AutoSize = true;
            this.lblNumbersFile.Location = new Point(10, 25);
            this.lblNumbersFile.Text = "File numeri:";

            // txtNumbersFile
            this.txtNumbersFile.Location = new Point(100, 22);
            this.txtNumbersFile.Name = "txtNumbersFile";
            this.txtNumbersFile.ReadOnly = true;
            this.txtNumbersFile.Size = new Size(650, 23);
            this.txtNumbersFile.TabIndex = 0;

            // btnBrowseNumbers
            this.btnBrowseNumbers.Location = new Point(760, 21);
            this.btnBrowseNumbers.Name = "btnBrowseNumbers";
            this.btnBrowseNumbers.Size = new Size(90, 25);
            this.btnBrowseNumbers.Text = "Sfoglia...";
            this.btnBrowseNumbers.Click += new EventHandler(this.btnBrowseNumbers_Click);

            // lblNumberCount
            this.lblNumberCount.AutoSize = true;
            this.lblNumberCount.Location = new Point(10, 55);
            this.lblNumberCount.Name = "lblNumberCount";
            this.lblNumberCount.Text = "Totale numeri: 0";

            // dgvNumbers
            this.dgvNumbers.AllowUserToAddRows = false;
            this.dgvNumbers.AllowUserToDeleteRows = false;
            this.dgvNumbers.Location = new Point(10, 80);
            this.dgvNumbers.Name = "dgvNumbers";
            this.dgvNumbers.ReadOnly = true;
            this.dgvNumbers.Size = new Size(845, 400);
            this.dgvNumbers.TabIndex = 1;
            this.dgvNumbers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // tabSchedule
            this.tabSchedule.Controls.Add(this.grpSchedule);
            this.tabSchedule.Controls.Add(this.grpTimeRange);
            this.tabSchedule.Controls.Add(this.grpNumbersPerEmail);
            this.tabSchedule.Location = new Point(4, 24);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Size = new Size(892, 532);
            this.tabSchedule.Text = "Schedulazione";

            // grpSchedule
            this.grpSchedule.Controls.Add(this.lblDays);
            this.grpSchedule.Controls.Add(this.flpDays);
            this.grpSchedule.Location = new Point(10, 10);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Size = new Size(870, 140);
            this.grpSchedule.Text = "Giorni del Mese (1-28)";
            this.grpSchedule.TabIndex = 0;

            // lblDays
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new Point(10, 20);
            this.lblDays.Text = "Seleziona i giorni in cui inviare le email:";

            // flpDays
            this.flpDays.Location = new Point(10, 40);
            this.flpDays.Name = "flpDays";
            this.flpDays.Size = new Size(850, 85);
            this.flpDays.TabIndex = 0;

            // grpTimeRange
            this.grpTimeRange.Controls.Add(this.lblMinTime);
            this.grpTimeRange.Controls.Add(this.tpMinTime);
            this.grpTimeRange.Controls.Add(this.lblMaxTime);
            this.grpTimeRange.Controls.Add(this.tpMaxTime);
            this.grpTimeRange.Location = new Point(10, 160);
            this.grpTimeRange.Name = "grpTimeRange";
            this.grpTimeRange.Size = new Size(400, 90);
            this.grpTimeRange.Text = "Range Orario";
            this.grpTimeRange.TabIndex = 1;

            // lblMinTime
            this.lblMinTime.AutoSize = true;
            this.lblMinTime.Location = new Point(10, 28);
            this.lblMinTime.Text = "Orario minimo:";

            // tpMinTime
            this.tpMinTime.Format = DateTimePickerFormat.Time;
            this.tpMinTime.Location = new Point(120, 25);
            this.tpMinTime.Name = "tpMinTime";
            this.tpMinTime.ShowUpDown = true;
            this.tpMinTime.Size = new Size(100, 23);
            this.tpMinTime.Value = DateTime.Today.AddHours(8);

            // lblMaxTime
            this.lblMaxTime.AutoSize = true;
            this.lblMaxTime.Location = new Point(10, 58);
            this.lblMaxTime.Text = "Orario massimo:";

            // tpMaxTime
            this.tpMaxTime.Format = DateTimePickerFormat.Time;
            this.tpMaxTime.Location = new Point(120, 55);
            this.tpMaxTime.Name = "tpMaxTime";
            this.tpMaxTime.ShowUpDown = true;
            this.tpMaxTime.Size = new Size(100, 23);
            this.tpMaxTime.Value = DateTime.Today.AddHours(17);

            // grpNumbersPerEmail
            this.grpNumbersPerEmail.Controls.Add(this.lblNumbersPerEmail);
            this.grpNumbersPerEmail.Controls.Add(this.nudNumbersPerEmail);
            this.grpNumbersPerEmail.Location = new Point(420, 160);
            this.grpNumbersPerEmail.Name = "grpNumbersPerEmail";
            this.grpNumbersPerEmail.Size = new Size(300, 90);
            this.grpNumbersPerEmail.Text = "Numeri per Email";
            this.grpNumbersPerEmail.TabIndex = 2;

            // lblNumbersPerEmail
            this.lblNumbersPerEmail.AutoSize = true;
            this.lblNumbersPerEmail.Location = new Point(10, 35);
            this.lblNumbersPerEmail.Text = "Numeri da inviare:";

            // nudNumbersPerEmail
            this.nudNumbersPerEmail.Location = new Point(130, 32);
            this.nudNumbersPerEmail.Minimum = 2;
            this.nudNumbersPerEmail.Maximum = 50;
            this.nudNumbersPerEmail.Value = 10;
            this.nudNumbersPerEmail.Name = "nudNumbersPerEmail";
            this.nudNumbersPerEmail.Size = new Size(80, 23);

            // tabEmail
            this.tabEmail.Controls.Add(this.grpSmtp);
            this.tabEmail.Controls.Add(this.grpImap);
            this.tabEmail.Controls.Add(this.grpCredentials);
            this.tabEmail.Controls.Add(this.grpMessage);
            this.tabEmail.Location = new Point(4, 24);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Size = new Size(892, 532);
            this.tabEmail.Text = "Email";

            // grpSmtp
            this.grpSmtp.Controls.Add(this.lblSmtpServer);
            this.grpSmtp.Controls.Add(this.txtSmtpServer);
            this.grpSmtp.Controls.Add(this.lblSmtpPort);
            this.grpSmtp.Controls.Add(this.nudSmtpPort);
            this.grpSmtp.Controls.Add(this.chkSmtpSsl);
            this.grpSmtp.Location = new Point(10, 10);
            this.grpSmtp.Name = "grpSmtp";
            this.grpSmtp.Size = new Size(420, 100);
            this.grpSmtp.Text = "Server SMTP (Invio)";
            this.grpSmtp.TabIndex = 0;

            // lblSmtpServer
            this.lblSmtpServer.AutoSize = true;
            this.lblSmtpServer.Location = new Point(10, 28);
            this.lblSmtpServer.Text = "Server:";

            // txtSmtpServer
            this.txtSmtpServer.Location = new Point(70, 25);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new Size(200, 23);

            // lblSmtpPort
            this.lblSmtpPort.AutoSize = true;
            this.lblSmtpPort.Location = new Point(280, 28);
            this.lblSmtpPort.Text = "Porta:";

            // nudSmtpPort
            this.nudSmtpPort.Location = new Point(320, 25);
            this.nudSmtpPort.Maximum = 65535;
            this.nudSmtpPort.Minimum = 1;
            this.nudSmtpPort.Value = 587;
            this.nudSmtpPort.Name = "nudSmtpPort";
            this.nudSmtpPort.Size = new Size(80, 23);

            // chkSmtpSsl
            this.chkSmtpSsl.AutoSize = true;
            this.chkSmtpSsl.Checked = true;
            this.chkSmtpSsl.Location = new Point(10, 60);
            this.chkSmtpSsl.Name = "chkSmtpSsl";
            this.chkSmtpSsl.Text = "Usa SSL/TLS";

            // grpImap
            this.grpImap.Controls.Add(this.lblImapServer);
            this.grpImap.Controls.Add(this.txtImapServer);
            this.grpImap.Controls.Add(this.lblImapPort);
            this.grpImap.Controls.Add(this.nudImapPort);
            this.grpImap.Controls.Add(this.chkImapSsl);
            this.grpImap.Location = new Point(440, 10);
            this.grpImap.Name = "grpImap";
            this.grpImap.Size = new Size(440, 100);
            this.grpImap.Text = "Server IMAP (Cartella Inviati)";
            this.grpImap.TabIndex = 1;

            // lblImapServer
            this.lblImapServer.AutoSize = true;
            this.lblImapServer.Location = new Point(10, 28);
            this.lblImapServer.Text = "Server:";

            // txtImapServer
            this.txtImapServer.Location = new Point(70, 25);
            this.txtImapServer.Name = "txtImapServer";
            this.txtImapServer.Size = new Size(200, 23);

            // lblImapPort
            this.lblImapPort.AutoSize = true;
            this.lblImapPort.Location = new Point(280, 28);
            this.lblImapPort.Text = "Porta:";

            // nudImapPort
            this.nudImapPort.Location = new Point(320, 25);
            this.nudImapPort.Maximum = 65535;
            this.nudImapPort.Minimum = 1;
            this.nudImapPort.Value = 993;
            this.nudImapPort.Name = "nudImapPort";
            this.nudImapPort.Size = new Size(80, 23);

            // chkImapSsl
            this.chkImapSsl.AutoSize = true;
            this.chkImapSsl.Checked = true;
            this.chkImapSsl.Location = new Point(10, 60);
            this.chkImapSsl.Name = "chkImapSsl";
            this.chkImapSsl.Text = "Usa SSL";

            // grpCredentials
            this.grpCredentials.Controls.Add(this.lblUsername);
            this.grpCredentials.Controls.Add(this.txtUsername);
            this.grpCredentials.Controls.Add(this.lblPassword);
            this.grpCredentials.Controls.Add(this.txtPassword);
            this.grpCredentials.Controls.Add(this.lblSenderDisplayName);
            this.grpCredentials.Controls.Add(this.txtSenderDisplayName);
            this.grpCredentials.Location = new Point(10, 120);
            this.grpCredentials.Name = "grpCredentials";
            this.grpCredentials.Size = new Size(870, 100);
            this.grpCredentials.Text = "Credenziali";
            this.grpCredentials.TabIndex = 2;

            // lblUsername
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new Point(10, 30);
            this.lblUsername.Text = "Username:";

            // txtUsername
            this.txtUsername.Location = new Point(80, 27);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(230, 23);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(330, 30);
            this.lblPassword.Text = "Password:";

            // txtPassword
            this.txtPassword.Location = new Point(400, 27);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new Size(200, 23);

            // lblSenderDisplayName
            this.lblSenderDisplayName.AutoSize = true;
            this.lblSenderDisplayName.Location = new Point(10, 62);
            this.lblSenderDisplayName.Text = "Nome mittente:";

            // txtSenderDisplayName
            this.txtSenderDisplayName.Location = new Point(110, 59);
            this.txtSenderDisplayName.Name = "txtSenderDisplayName";
            this.txtSenderDisplayName.Size = new Size(250, 23);

            // grpMessage
            this.grpMessage.Controls.Add(this.lblRecipients);
            this.grpMessage.Controls.Add(this.txtRecipients);
            this.grpMessage.Controls.Add(this.lblSubject);
            this.grpMessage.Controls.Add(this.txtSubject);
            this.grpMessage.Controls.Add(this.lblBodyTemplate);
            this.grpMessage.Controls.Add(this.txtBodyTemplate);
            this.grpMessage.Location = new Point(10, 230);
            this.grpMessage.Name = "grpMessage";
            this.grpMessage.Size = new Size(870, 290);
            this.grpMessage.Text = "Messaggio";
            this.grpMessage.TabIndex = 3;

            // lblRecipients
            this.lblRecipients.AutoSize = true;
            this.lblRecipients.Location = new Point(10, 28);
            this.lblRecipients.Text = "Destinatari (;):";

            // txtRecipients
            this.txtRecipients.Location = new Point(120, 25);
            this.txtRecipients.Name = "txtRecipients";
            this.txtRecipients.Size = new Size(730, 23);

            // lblSubject
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new Point(10, 60);
            this.lblSubject.Text = "Oggetto:";

            // txtSubject
            this.txtSubject.Location = new Point(120, 57);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new Size(730, 23);

            // lblBodyTemplate
            this.lblBodyTemplate.AutoSize = true;
            this.lblBodyTemplate.Location = new Point(10, 92);
            this.lblBodyTemplate.Text = "Corpo email (usa <numbers>):";

            // txtBodyTemplate
            this.txtBodyTemplate.Location = new Point(10, 115);
            this.txtBodyTemplate.Multiline = true;
            this.txtBodyTemplate.Name = "txtBodyTemplate";
            this.txtBodyTemplate.ScrollBars = ScrollBars.Vertical;
            this.txtBodyTemplate.Size = new Size(840, 155);
            this.txtBodyTemplate.Text = "Gentile cliente,\r\n\r\ndi seguito i numeri di telefono da verificare:\r\n\r\n<numbers>\r\n\r\nCordiali saluti";

            // tabSecurity
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

            // pnlButtons
            this.pnlButtons.Controls.Add(this.btnSaveConfig);
            this.pnlButtons.Controls.Add(this.btnLoadConfig);
            this.pnlButtons.Controls.Add(this.btnSchedule);
            this.pnlButtons.Controls.Add(this.btnSendNow);
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

            // btnSendNow
            this.btnSendNow.Location = new Point(490, 10);
            this.btnSendNow.Name = "btnSendNow";
            this.btnSendNow.Size = new Size(100, 28);
            this.btnSendNow.Text = "Invia Ora";
            this.btnSendNow.BackColor = Color.FromArgb(0, 120, 215);
            this.btnSendNow.ForeColor = Color.White;
            this.btnSendNow.Click += new EventHandler(this.btnSendNow_Click);

            // btnViewHistory
            this.btnViewHistory.Location = new Point(600, 10);
            this.btnViewHistory.Name = "btnViewHistory";
            this.btnViewHistory.Size = new Size(130, 28);
            this.btnViewHistory.Text = "Visualizza Storico";
            this.btnViewHistory.Click += new EventHandler(this.btnViewHistory_Click);

            // pnlHistory
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
            this.lblHistory.Text = "Storico Invii";

            // dgvHistory
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.Location = new Point(5, 25);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new Size(885, 165);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // SenderConfigForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(900, 650);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHistory);
            this.Font = new Font("Segoe UI", 9F);
            this.MinimumSize = new Size(916, 700);
            this.Name = "SenderConfigForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "AutoCons - Configurazione Sender";

            this.tabControl.ResumeLayout(false);
            this.tabNumbers.ResumeLayout(false);
            this.tabSchedule.ResumeLayout(false);
            this.tabEmail.ResumeLayout(false);
            this.tabSecurity.ResumeLayout(false);
            this.grpNumbersFile.ResumeLayout(false);
            this.grpNumbersFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgvNumbers).EndInit();
            this.grpSchedule.ResumeLayout(false);
            this.grpSchedule.PerformLayout();
            this.grpTimeRange.ResumeLayout(false);
            this.grpTimeRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudNumbersPerEmail).EndInit();
            this.grpSmtp.ResumeLayout(false);
            this.grpSmtp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudSmtpPort).EndInit();
            this.grpImap.ResumeLayout(false);
            this.grpImap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.nudImapPort).EndInit();
            this.grpCredentials.ResumeLayout(false);
            this.grpCredentials.PerformLayout();
            this.grpMessage.ResumeLayout(false);
            this.grpMessage.PerformLayout();
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
