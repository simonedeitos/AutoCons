namespace AutoCons
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel = new TableLayoutPanel();
            pnlSender = new Panel();
            btnSender = new Button();
            lblSenderDesc = new Label();
            lblSenderTitle = new Label();
            pnlReceiver = new Panel();
            btnReceiver = new Button();
            lblReceiverDesc = new Label();
            lblReceiverTitle = new Label();
            statusStrip = new StatusStrip();
            tsslStatus = new ToolStripStatusLabel();
            lblVersion = new Label();
            tableLayoutPanel.SuspendLayout();
            pnlSender.SuspendLayout();
            pnlReceiver.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(pnlSender, 0, 0);
            tableLayoutPanel.Controls.Add(pnlReceiver, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(800, 420);
            tableLayoutPanel.TabIndex = 0;
            // 
            // pnlSender
            // 
            pnlSender.BackColor = Color.FromArgb(230, 244, 255);
            pnlSender.Controls.Add(btnSender);
            pnlSender.Controls.Add(lblSenderDesc);
            pnlSender.Controls.Add(lblSenderTitle);
            pnlSender.Dock = DockStyle.Fill;
            pnlSender.Location = new Point(20, 20);
            pnlSender.Margin = new Padding(20);
            pnlSender.Name = "pnlSender";
            pnlSender.Size = new Size(360, 380);
            pnlSender.TabIndex = 0;
            // 
            // btnSender
            // 
            btnSender.BackColor = Color.FromArgb(0, 120, 215);
            btnSender.FlatStyle = FlatStyle.Flat;
            btnSender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSender.ForeColor = Color.White;
            btnSender.Location = new Point(60, 260);
            btnSender.Name = "btnSender";
            btnSender.Size = new Size(240, 50);
            btnSender.TabIndex = 0;
            btnSender.Text = "Configura Sender";
            btnSender.UseVisualStyleBackColor = false;
            btnSender.Click += btnSender_Click;
            // 
            // lblSenderDesc
            // 
            lblSenderDesc.Font = new Font("Segoe UI", 10F);
            lblSenderDesc.ForeColor = Color.FromArgb(60, 60, 60);
            lblSenderDesc.Location = new Point(20, 100);
            lblSenderDesc.Name = "lblSenderDesc";
            lblSenderDesc.Size = new Size(320, 120);
            lblSenderDesc.TabIndex = 1;
            lblSenderDesc.Text = "Invia email con numeri di telefono da verificare.\n\nCarica la lista numeri, configura la schedulazione e imposta il server email di invio.";
            lblSenderDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSenderTitle
            // 
            lblSenderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSenderTitle.ForeColor = Color.FromArgb(0, 80, 160);
            lblSenderTitle.Location = new Point(20, 40);
            lblSenderTitle.Name = "lblSenderTitle";
            lblSenderTitle.Size = new Size(320, 40);
            lblSenderTitle.TabIndex = 2;
            lblSenderTitle.Text = "📤  Modalità Sender";
            lblSenderTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlReceiver
            // 
            pnlReceiver.BackColor = Color.FromArgb(230, 255, 240);
            pnlReceiver.Controls.Add(btnReceiver);
            pnlReceiver.Controls.Add(lblReceiverDesc);
            pnlReceiver.Controls.Add(lblReceiverTitle);
            pnlReceiver.Dock = DockStyle.Fill;
            pnlReceiver.Location = new Point(420, 20);
            pnlReceiver.Margin = new Padding(20);
            pnlReceiver.Name = "pnlReceiver";
            pnlReceiver.Size = new Size(360, 380);
            pnlReceiver.TabIndex = 1;
            // 
            // btnReceiver
            // 
            btnReceiver.BackColor = Color.FromArgb(0, 160, 80);
            btnReceiver.FlatStyle = FlatStyle.Flat;
            btnReceiver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReceiver.ForeColor = Color.White;
            btnReceiver.Location = new Point(60, 260);
            btnReceiver.Name = "btnReceiver";
            btnReceiver.Size = new Size(240, 50);
            btnReceiver.TabIndex = 0;
            btnReceiver.Text = "Configura Receiver";
            btnReceiver.UseVisualStyleBackColor = false;
            btnReceiver.Click += btnReceiver_Click;
            // 
            // lblReceiverDesc
            // 
            lblReceiverDesc.Font = new Font("Segoe UI", 10F);
            lblReceiverDesc.ForeColor = Color.FromArgb(60, 60, 60);
            lblReceiverDesc.Location = new Point(20, 100);
            lblReceiverDesc.Name = "lblReceiverDesc";
            lblReceiverDesc.Size = new Size(320, 120);
            lblReceiverDesc.TabIndex = 1;
            lblReceiverDesc.Text = "Ricevi e analizza email con numeri da verificare.\n\nCarica il CSV dei consensi, configura la casella IMAP e imposta la risposta automatica.";
            lblReceiverDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblReceiverTitle
            // 
            lblReceiverTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblReceiverTitle.ForeColor = Color.FromArgb(0, 130, 60);
            lblReceiverTitle.Location = new Point(20, 40);
            lblReceiverTitle.Name = "lblReceiverTitle";
            lblReceiverTitle.Size = new Size(320, 40);
            lblReceiverTitle.TabIndex = 2;
            lblReceiverTitle.Text = "📥  Modalità Receiver";
            lblReceiverTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { tsslStatus });
            statusStrip.Location = new Point(0, 420);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 1;
            // 
            // tsslStatus
            // 
            tsslStatus.Name = "tsslStatus";
            tsslStatus.Size = new Size(43, 17);
            tsslStatus.Text = "Pronto";
            // 
            // lblVersion
            // 
            lblVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVersion.Font = new Font("Segoe UI", 8F);
            lblVersion.ForeColor = Color.Gray;
            lblVersion.Location = new Point(680, 4);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(110, 20);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "AutoCons v1.0";
            lblVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 442);
            Controls.Add(lblVersion);
            Controls.Add(tableLayoutPanel);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoCons - Verifica Consensi Telefonici";
            tableLayoutPanel.ResumeLayout(false);
            pnlSender.ResumeLayout(false);
            pnlReceiver.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Panel pnlSender;
        private Label lblSenderTitle;
        private Label lblSenderDesc;
        private Button btnSender;
        private Panel pnlReceiver;
        private Label lblReceiverTitle;
        private Label lblReceiverDesc;
        private Button btnReceiver;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel tsslStatus;
        private Label lblVersion;
    }
}

