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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiverConfigForm));
            tabControl = new TabControl();
            tabImap = new TabPage();
            grpImap = new GroupBox();
            lblImapServer = new Label();
            txtImapServer = new TextBox();
            lblImapPort = new Label();
            nudImapPort = new NumericUpDown();
            chkImapSsl = new CheckBox();
            lblImapUsername = new Label();
            txtImapUsername = new TextBox();
            lblImapPassword = new Label();
            txtImapPassword = new TextBox();
            grpMonitor = new GroupBox();
            lblMonitoredSender = new Label();
            txtMonitoredSender = new TextBox();
            grpSchedule = new GroupBox();
            lblCheckTime = new Label();
            tpCheckTime = new DateTimePicker();
            tabSmtp = new TabPage();
            grpSmtp = new GroupBox();
            lblSmtpServer = new Label();
            txtSmtpServer = new TextBox();
            lblSmtpPort = new Label();
            nudSmtpPort = new NumericUpDown();
            chkSmtpSsl = new CheckBox();
            lblSmtpUsername = new Label();
            txtSmtpUsername = new TextBox();
            lblSmtpPassword = new Label();
            txtSmtpPassword = new TextBox();
            lblSenderDisplayName = new Label();
            txtSenderDisplayName = new TextBox();
            grpSentImap = new GroupBox();
            lblSentImapServer = new Label();
            txtSentImapServer = new TextBox();
            lblSentImapPort = new Label();
            nudSentImapPort = new NumericUpDown();
            chkSentImapSsl = new CheckBox();
            tabCsv = new TabPage();
            grpCsvFile = new GroupBox();
            lblCsvFile = new Label();
            txtCsvFile = new TextBox();
            btnBrowseCsv = new Button();
            lblPhoneColumn = new Label();
            cmbPhoneColumn = new ComboBox();
            lblCsvInfo = new Label();
            dgvCsvPreview = new DataGridView();
            tabReply = new TabPage();
            grpReply = new GroupBox();
            lblReplyTemplate = new Label();
            txtReplyTemplate = new TextBox();
            tabSecurity = new TabPage();
            grpSecurity = new GroupBox();
            lblHmacKey = new Label();
            txtHmacKey = new TextBox();
            pnlButtons = new Panel();
            btnSaveConfig = new Button();
            btnLoadConfig = new Button();
            btnSchedule = new Button();
            btnCheckNow = new Button();
            btnViewHistory = new Button();
            pnlHistory = new Panel();
            lblHistory = new Label();
            dgvHistory = new DataGridView();
            tabControl.SuspendLayout();
            tabImap.SuspendLayout();
            grpImap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudImapPort).BeginInit();
            grpMonitor.SuspendLayout();
            grpSchedule.SuspendLayout();
            tabSmtp.SuspendLayout();
            grpSmtp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSmtpPort).BeginInit();
            grpSentImap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSentImapPort).BeginInit();
            tabCsv.SuspendLayout();
            grpCsvFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCsvPreview).BeginInit();
            tabReply.SuspendLayout();
            grpReply.SuspendLayout();
            tabSecurity.SuspendLayout();
            grpSecurity.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabImap);
            tabControl.Controls.Add(tabSmtp);
            tabControl.Controls.Add(tabCsv);
            tabControl.Controls.Add(tabReply);
            tabControl.Controls.Add(tabSecurity);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(900, 416);
            tabControl.TabIndex = 0;
            // 
            // tabImap
            // 
            tabImap.Controls.Add(grpImap);
            tabImap.Controls.Add(grpMonitor);
            tabImap.Controls.Add(grpSchedule);
            tabImap.Location = new Point(4, 24);
            tabImap.Name = "tabImap";
            tabImap.Size = new Size(892, 388);
            tabImap.TabIndex = 0;
            tabImap.Text = "IMAP Ricezione";
            // 
            // grpImap
            // 
            grpImap.Controls.Add(lblImapServer);
            grpImap.Controls.Add(txtImapServer);
            grpImap.Controls.Add(lblImapPort);
            grpImap.Controls.Add(nudImapPort);
            grpImap.Controls.Add(chkImapSsl);
            grpImap.Controls.Add(lblImapUsername);
            grpImap.Controls.Add(txtImapUsername);
            grpImap.Controls.Add(lblImapPassword);
            grpImap.Controls.Add(txtImapPassword);
            grpImap.Location = new Point(10, 10);
            grpImap.Name = "grpImap";
            grpImap.Size = new Size(870, 140);
            grpImap.TabIndex = 0;
            grpImap.TabStop = false;
            grpImap.Text = "Server IMAP (Ricezione Email)";
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
            txtImapServer.Location = new Point(80, 25);
            txtImapServer.Name = "txtImapServer";
            txtImapServer.Size = new Size(230, 23);
            txtImapServer.TabIndex = 1;
            // 
            // lblImapPort
            // 
            lblImapPort.AutoSize = true;
            lblImapPort.Location = new Point(325, 28);
            lblImapPort.Name = "lblImapPort";
            lblImapPort.Size = new Size(38, 15);
            lblImapPort.TabIndex = 2;
            lblImapPort.Text = "Porta:";
            // 
            // nudImapPort
            // 
            nudImapPort.Location = new Point(370, 25);
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
            chkImapSsl.Location = new Point(460, 27);
            chkImapSsl.Name = "chkImapSsl";
            chkImapSsl.Size = new Size(66, 19);
            chkImapSsl.TabIndex = 4;
            chkImapSsl.Text = "Usa SSL";
            // 
            // lblImapUsername
            // 
            lblImapUsername.AutoSize = true;
            lblImapUsername.Location = new Point(10, 62);
            lblImapUsername.Name = "lblImapUsername";
            lblImapUsername.Size = new Size(63, 15);
            lblImapUsername.TabIndex = 5;
            lblImapUsername.Text = "Username:";
            // 
            // txtImapUsername
            // 
            txtImapUsername.Location = new Point(80, 59);
            txtImapUsername.Name = "txtImapUsername";
            txtImapUsername.Size = new Size(230, 23);
            txtImapUsername.TabIndex = 6;
            // 
            // lblImapPassword
            // 
            lblImapPassword.AutoSize = true;
            lblImapPassword.Location = new Point(10, 96);
            lblImapPassword.Name = "lblImapPassword";
            lblImapPassword.Size = new Size(60, 15);
            lblImapPassword.TabIndex = 7;
            lblImapPassword.Text = "Password:";
            // 
            // txtImapPassword
            // 
            txtImapPassword.Location = new Point(80, 93);
            txtImapPassword.Name = "txtImapPassword";
            txtImapPassword.PasswordChar = '●';
            txtImapPassword.Size = new Size(230, 23);
            txtImapPassword.TabIndex = 8;
            // 
            // grpMonitor
            // 
            grpMonitor.Controls.Add(lblMonitoredSender);
            grpMonitor.Controls.Add(txtMonitoredSender);
            grpMonitor.Location = new Point(10, 160);
            grpMonitor.Name = "grpMonitor";
            grpMonitor.Size = new Size(870, 70);
            grpMonitor.TabIndex = 1;
            grpMonitor.TabStop = false;
            grpMonitor.Text = "Filtro Mittente";
            // 
            // lblMonitoredSender
            // 
            lblMonitoredSender.AutoSize = true;
            lblMonitoredSender.Location = new Point(10, 30);
            lblMonitoredSender.Name = "lblMonitoredSender";
            lblMonitoredSender.Size = new Size(150, 15);
            lblMonitoredSender.TabIndex = 0;
            lblMonitoredSender.Text = "Email mittente monitorato:";
            // 
            // txtMonitoredSender
            // 
            txtMonitoredSender.Location = new Point(185, 27);
            txtMonitoredSender.Name = "txtMonitoredSender";
            txtMonitoredSender.Size = new Size(300, 23);
            txtMonitoredSender.TabIndex = 1;
            // 
            // grpSchedule
            // 
            grpSchedule.Controls.Add(lblCheckTime);
            grpSchedule.Controls.Add(tpCheckTime);
            grpSchedule.Location = new Point(10, 240);
            grpSchedule.Name = "grpSchedule";
            grpSchedule.Size = new Size(870, 70);
            grpSchedule.TabIndex = 2;
            grpSchedule.TabStop = false;
            grpSchedule.Text = "Schedulazione Giornaliera";
            // 
            // lblCheckTime
            // 
            lblCheckTime.AutoSize = true;
            lblCheckTime.Location = new Point(10, 30);
            lblCheckTime.Name = "lblCheckTime";
            lblCheckTime.Size = new Size(154, 15);
            lblCheckTime.TabIndex = 0;
            lblCheckTime.Text = "Orario controllo giornaliero:";
            // 
            // tpCheckTime
            // 
            tpCheckTime.Format = DateTimePickerFormat.Time;
            tpCheckTime.Location = new Point(200, 27);
            tpCheckTime.Name = "tpCheckTime";
            tpCheckTime.ShowUpDown = true;
            tpCheckTime.Size = new Size(100, 23);
            tpCheckTime.TabIndex = 1;
            tpCheckTime.Value = new DateTime(2026, 4, 1, 18, 15, 0, 0);
            // 
            // tabSmtp
            // 
            tabSmtp.Controls.Add(grpSmtp);
            tabSmtp.Controls.Add(grpSentImap);
            tabSmtp.Location = new Point(4, 24);
            tabSmtp.Name = "tabSmtp";
            tabSmtp.Size = new Size(892, 388);
            tabSmtp.TabIndex = 1;
            tabSmtp.Text = "SMTP Risposta";
            // 
            // grpSmtp
            // 
            grpSmtp.Controls.Add(lblSmtpServer);
            grpSmtp.Controls.Add(txtSmtpServer);
            grpSmtp.Controls.Add(lblSmtpPort);
            grpSmtp.Controls.Add(nudSmtpPort);
            grpSmtp.Controls.Add(chkSmtpSsl);
            grpSmtp.Controls.Add(lblSmtpUsername);
            grpSmtp.Controls.Add(txtSmtpUsername);
            grpSmtp.Controls.Add(lblSmtpPassword);
            grpSmtp.Controls.Add(txtSmtpPassword);
            grpSmtp.Controls.Add(lblSenderDisplayName);
            grpSmtp.Controls.Add(txtSenderDisplayName);
            grpSmtp.Location = new Point(10, 10);
            grpSmtp.Name = "grpSmtp";
            grpSmtp.Size = new Size(870, 170);
            grpSmtp.TabIndex = 0;
            grpSmtp.TabStop = false;
            grpSmtp.Text = "Server SMTP (Invio Risposta)";
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
            txtSmtpServer.Location = new Point(80, 25);
            txtSmtpServer.Name = "txtSmtpServer";
            txtSmtpServer.Size = new Size(230, 23);
            txtSmtpServer.TabIndex = 1;
            // 
            // lblSmtpPort
            // 
            lblSmtpPort.AutoSize = true;
            lblSmtpPort.Location = new Point(325, 28);
            lblSmtpPort.Name = "lblSmtpPort";
            lblSmtpPort.Size = new Size(38, 15);
            lblSmtpPort.TabIndex = 2;
            lblSmtpPort.Text = "Porta:";
            // 
            // nudSmtpPort
            // 
            nudSmtpPort.Location = new Point(370, 25);
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
            chkSmtpSsl.Location = new Point(460, 27);
            chkSmtpSsl.Name = "chkSmtpSsl";
            chkSmtpSsl.Size = new Size(89, 19);
            chkSmtpSsl.TabIndex = 4;
            chkSmtpSsl.Text = "Usa SSL/TLS";
            // 
            // lblSmtpUsername
            // 
            lblSmtpUsername.AutoSize = true;
            lblSmtpUsername.Location = new Point(10, 62);
            lblSmtpUsername.Name = "lblSmtpUsername";
            lblSmtpUsername.Size = new Size(63, 15);
            lblSmtpUsername.TabIndex = 5;
            lblSmtpUsername.Text = "Username:";
            // 
            // txtSmtpUsername
            // 
            txtSmtpUsername.Location = new Point(80, 59);
            txtSmtpUsername.Name = "txtSmtpUsername";
            txtSmtpUsername.Size = new Size(230, 23);
            txtSmtpUsername.TabIndex = 6;
            // 
            // lblSmtpPassword
            // 
            lblSmtpPassword.AutoSize = true;
            lblSmtpPassword.Location = new Point(10, 96);
            lblSmtpPassword.Name = "lblSmtpPassword";
            lblSmtpPassword.Size = new Size(60, 15);
            lblSmtpPassword.TabIndex = 7;
            lblSmtpPassword.Text = "Password:";
            // 
            // txtSmtpPassword
            // 
            txtSmtpPassword.Location = new Point(80, 93);
            txtSmtpPassword.Name = "txtSmtpPassword";
            txtSmtpPassword.PasswordChar = '●';
            txtSmtpPassword.Size = new Size(230, 23);
            txtSmtpPassword.TabIndex = 8;
            // 
            // lblSenderDisplayName
            // 
            lblSenderDisplayName.AutoSize = true;
            lblSenderDisplayName.Location = new Point(10, 130);
            lblSenderDisplayName.Name = "lblSenderDisplayName";
            lblSenderDisplayName.Size = new Size(91, 15);
            lblSenderDisplayName.TabIndex = 9;
            lblSenderDisplayName.Text = "Nome mittente:";
            // 
            // txtSenderDisplayName
            // 
            txtSenderDisplayName.Location = new Point(110, 127);
            txtSenderDisplayName.Name = "txtSenderDisplayName";
            txtSenderDisplayName.Size = new Size(250, 23);
            txtSenderDisplayName.TabIndex = 10;
            // 
            // grpSentImap
            // 
            grpSentImap.Controls.Add(lblSentImapServer);
            grpSentImap.Controls.Add(txtSentImapServer);
            grpSentImap.Controls.Add(lblSentImapPort);
            grpSentImap.Controls.Add(nudSentImapPort);
            grpSentImap.Controls.Add(chkSentImapSsl);
            grpSentImap.Location = new Point(10, 190);
            grpSentImap.Name = "grpSentImap";
            grpSentImap.Size = new Size(870, 80);
            grpSentImap.TabIndex = 1;
            grpSentImap.TabStop = false;
            grpSentImap.Text = "IMAP per Salvataggio Risposte Inviate";
            // 
            // lblSentImapServer
            // 
            lblSentImapServer.AutoSize = true;
            lblSentImapServer.Location = new Point(10, 30);
            lblSentImapServer.Name = "lblSentImapServer";
            lblSentImapServer.Size = new Size(42, 15);
            lblSentImapServer.TabIndex = 0;
            lblSentImapServer.Text = "Server:";
            // 
            // txtSentImapServer
            // 
            txtSentImapServer.Location = new Point(80, 27);
            txtSentImapServer.Name = "txtSentImapServer";
            txtSentImapServer.Size = new Size(230, 23);
            txtSentImapServer.TabIndex = 1;
            // 
            // lblSentImapPort
            // 
            lblSentImapPort.AutoSize = true;
            lblSentImapPort.Location = new Point(325, 30);
            lblSentImapPort.Name = "lblSentImapPort";
            lblSentImapPort.Size = new Size(38, 15);
            lblSentImapPort.TabIndex = 2;
            lblSentImapPort.Text = "Porta:";
            // 
            // nudSentImapPort
            // 
            nudSentImapPort.Location = new Point(370, 27);
            nudSentImapPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            nudSentImapPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSentImapPort.Name = "nudSentImapPort";
            nudSentImapPort.Size = new Size(80, 23);
            nudSentImapPort.TabIndex = 3;
            nudSentImapPort.Value = new decimal(new int[] { 993, 0, 0, 0 });
            // 
            // chkSentImapSsl
            // 
            chkSentImapSsl.AutoSize = true;
            chkSentImapSsl.Checked = true;
            chkSentImapSsl.CheckState = CheckState.Checked;
            chkSentImapSsl.Location = new Point(460, 30);
            chkSentImapSsl.Name = "chkSentImapSsl";
            chkSentImapSsl.Size = new Size(66, 19);
            chkSentImapSsl.TabIndex = 4;
            chkSentImapSsl.Text = "Usa SSL";
            // 
            // tabCsv
            // 
            tabCsv.Controls.Add(grpCsvFile);
            tabCsv.Location = new Point(4, 24);
            tabCsv.Name = "tabCsv";
            tabCsv.Size = new Size(892, 388);
            tabCsv.TabIndex = 2;
            tabCsv.Text = "File CSV Consensi";
            // 
            // grpCsvFile
            // 
            grpCsvFile.Controls.Add(lblCsvFile);
            grpCsvFile.Controls.Add(txtCsvFile);
            grpCsvFile.Controls.Add(btnBrowseCsv);
            grpCsvFile.Controls.Add(lblPhoneColumn);
            grpCsvFile.Controls.Add(cmbPhoneColumn);
            grpCsvFile.Controls.Add(lblCsvInfo);
            grpCsvFile.Controls.Add(dgvCsvPreview);
            grpCsvFile.Location = new Point(10, 10);
            grpCsvFile.Name = "grpCsvFile";
            grpCsvFile.Size = new Size(870, 510);
            grpCsvFile.TabIndex = 0;
            grpCsvFile.TabStop = false;
            grpCsvFile.Text = "File CSV Consensi";
            // 
            // lblCsvFile
            // 
            lblCsvFile.AutoSize = true;
            lblCsvFile.Location = new Point(10, 25);
            lblCsvFile.Name = "lblCsvFile";
            lblCsvFile.Size = new Size(52, 15);
            lblCsvFile.TabIndex = 0;
            lblCsvFile.Text = "File CSV:";
            // 
            // txtCsvFile
            // 
            txtCsvFile.Location = new Point(80, 22);
            txtCsvFile.Name = "txtCsvFile";
            txtCsvFile.ReadOnly = true;
            txtCsvFile.Size = new Size(650, 23);
            txtCsvFile.TabIndex = 1;
            // 
            // btnBrowseCsv
            // 
            btnBrowseCsv.Location = new Point(740, 21);
            btnBrowseCsv.Name = "btnBrowseCsv";
            btnBrowseCsv.Size = new Size(90, 25);
            btnBrowseCsv.TabIndex = 2;
            btnBrowseCsv.Text = "Sfoglia...";
            btnBrowseCsv.Click += btnBrowseCsv_Click;
            // 
            // lblPhoneColumn
            // 
            lblPhoneColumn.AutoSize = true;
            lblPhoneColumn.Location = new Point(10, 58);
            lblPhoneColumn.Name = "lblPhoneColumn";
            lblPhoneColumn.Size = new Size(96, 15);
            lblPhoneColumn.TabIndex = 3;
            lblPhoneColumn.Text = "Colonna numeri:";
            // 
            // cmbPhoneColumn
            // 
            cmbPhoneColumn.Location = new Point(120, 55);
            cmbPhoneColumn.Name = "cmbPhoneColumn";
            cmbPhoneColumn.Size = new Size(200, 23);
            cmbPhoneColumn.TabIndex = 4;
            // 
            // lblCsvInfo
            // 
            lblCsvInfo.AutoSize = true;
            lblCsvInfo.Location = new Point(10, 90);
            lblCsvInfo.Name = "lblCsvInfo";
            lblCsvInfo.Size = new Size(216, 15);
            lblCsvInfo.TabIndex = 5;
            lblCsvInfo.Text = "Carica un file per vedere le informazioni";
            // 
            // dgvCsvPreview
            // 
            dgvCsvPreview.AllowUserToAddRows = false;
            dgvCsvPreview.AllowUserToDeleteRows = false;
            dgvCsvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCsvPreview.Location = new Point(10, 115);
            dgvCsvPreview.Name = "dgvCsvPreview";
            dgvCsvPreview.ReadOnly = true;
            dgvCsvPreview.Size = new Size(845, 380);
            dgvCsvPreview.TabIndex = 1;
            // 
            // tabReply
            // 
            tabReply.Controls.Add(grpReply);
            tabReply.Location = new Point(4, 24);
            tabReply.Name = "tabReply";
            tabReply.Size = new Size(892, 388);
            tabReply.TabIndex = 3;
            tabReply.Text = "Risposta";
            // 
            // grpReply
            // 
            grpReply.Controls.Add(lblReplyTemplate);
            grpReply.Controls.Add(txtReplyTemplate);
            grpReply.Location = new Point(10, 10);
            grpReply.Name = "grpReply";
            grpReply.Size = new Size(870, 510);
            grpReply.TabIndex = 0;
            grpReply.TabStop = false;
            grpReply.Text = "Template Risposta";
            // 
            // lblReplyTemplate
            // 
            lblReplyTemplate.AutoSize = true;
            lblReplyTemplate.Location = new Point(10, 25);
            lblReplyTemplate.Name = "lblReplyTemplate";
            lblReplyTemplate.Size = new Size(658, 15);
            lblReplyTemplate.TabIndex = 0;
            lblReplyTemplate.Text = "Template del messaggio di risposta (usa <notfound>...</notfound> per i numeri non trovati, {numbers} come segnaposto):";
            // 
            // txtReplyTemplate
            // 
            txtReplyTemplate.Location = new Point(10, 86);
            txtReplyTemplate.Multiline = true;
            txtReplyTemplate.Name = "txtReplyTemplate";
            txtReplyTemplate.ScrollBars = ScrollBars.Vertical;
            txtReplyTemplate.Size = new Size(840, 289);
            txtReplyTemplate.TabIndex = 1;
            txtReplyTemplate.Text = resources.GetString("txtReplyTemplate.Text");
            // 
            // tabSecurity
            // 
            tabSecurity.Controls.Add(grpSecurity);
            tabSecurity.Location = new Point(4, 24);
            tabSecurity.Name = "tabSecurity";
            tabSecurity.Size = new Size(892, 388);
            tabSecurity.TabIndex = 4;
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
            pnlButtons.Controls.Add(btnCheckNow);
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
            // btnCheckNow
            // 
            btnCheckNow.BackColor = Color.FromArgb(0, 160, 80);
            btnCheckNow.ForeColor = Color.White;
            btnCheckNow.Location = new Point(490, 10);
            btnCheckNow.Name = "btnCheckNow";
            btnCheckNow.Size = new Size(110, 28);
            btnCheckNow.TabIndex = 3;
            btnCheckNow.Text = "Controlla Ora";
            btnCheckNow.UseVisualStyleBackColor = false;
            btnCheckNow.Click += btnCheckNow_Click;
            // 
            // btnViewHistory
            // 
            btnViewHistory.Location = new Point(610, 10);
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
            lblHistory.Size = new Size(116, 15);
            lblHistory.TabIndex = 0;
            lblHistory.Text = "Storico Elaborazioni";
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
            // ReceiverConfigForm
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
            Name = "ReceiverConfigForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AutoCons - Configurazione Receiver";
            Load += ReceiverConfigForm_Load;
            tabControl.ResumeLayout(false);
            tabImap.ResumeLayout(false);
            grpImap.ResumeLayout(false);
            grpImap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudImapPort).EndInit();
            grpMonitor.ResumeLayout(false);
            grpMonitor.PerformLayout();
            grpSchedule.ResumeLayout(false);
            grpSchedule.PerformLayout();
            tabSmtp.ResumeLayout(false);
            grpSmtp.ResumeLayout(false);
            grpSmtp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSmtpPort).EndInit();
            grpSentImap.ResumeLayout(false);
            grpSentImap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSentImapPort).EndInit();
            tabCsv.ResumeLayout(false);
            grpCsvFile.ResumeLayout(false);
            grpCsvFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCsvPreview).EndInit();
            tabReply.ResumeLayout(false);
            grpReply.ResumeLayout(false);
            grpReply.PerformLayout();
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
