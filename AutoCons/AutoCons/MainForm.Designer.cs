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
            components = new System.ComponentModel.Container();

            this.tableLayoutPanel = new TableLayoutPanel();
            this.pnlSender = new Panel();
            this.lblSenderTitle = new Label();
            this.lblSenderDesc = new Label();
            this.btnSender = new Button();
            this.pnlReceiver = new Panel();
            this.lblReceiverTitle = new Label();
            this.lblReceiverDesc = new Label();
            this.btnReceiver = new Button();
            this.statusStrip = new StatusStrip();
            this.tsslStatus = new ToolStripStatusLabel();
            this.lblVersion = new Label();

            this.tableLayoutPanel.SuspendLayout();
            this.pnlSender.SuspendLayout();
            this.pnlReceiver.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // tableLayoutPanel
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.pnlSender, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.pnlReceiver, 1, 0);
            this.tableLayoutPanel.Dock = DockStyle.Fill;
            this.tableLayoutPanel.Location = new Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new Size(800, 420);
            this.tableLayoutPanel.TabIndex = 0;

            // pnlSender
            this.pnlSender.BackColor = Color.FromArgb(230, 244, 255);
            this.pnlSender.Controls.Add(this.btnSender);
            this.pnlSender.Controls.Add(this.lblSenderDesc);
            this.pnlSender.Controls.Add(this.lblSenderTitle);
            this.pnlSender.Dock = DockStyle.Fill;
            this.pnlSender.Margin = new Padding(20);
            this.pnlSender.Name = "pnlSender";
            this.pnlSender.Size = new Size(360, 380);
            this.pnlSender.TabIndex = 0;

            // lblSenderTitle
            this.lblSenderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblSenderTitle.ForeColor = Color.FromArgb(0, 80, 160);
            this.lblSenderTitle.Location = new Point(20, 40);
            this.lblSenderTitle.Name = "lblSenderTitle";
            this.lblSenderTitle.Size = new Size(320, 40);
            this.lblSenderTitle.Text = "📤  Modalità Sender";
            this.lblSenderTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblSenderDesc
            this.lblSenderDesc.Font = new Font("Segoe UI", 10F);
            this.lblSenderDesc.ForeColor = Color.FromArgb(60, 60, 60);
            this.lblSenderDesc.Location = new Point(20, 100);
            this.lblSenderDesc.Name = "lblSenderDesc";
            this.lblSenderDesc.Size = new Size(320, 120);
            this.lblSenderDesc.Text = "Invia email con numeri di telefono da verificare.\n\nCarica la lista numeri, configura la schedulazione e imposta il server email di invio.";
            this.lblSenderDesc.TextAlign = ContentAlignment.TopCenter;

            // btnSender
            this.btnSender.BackColor = Color.FromArgb(0, 120, 215);
            this.btnSender.FlatStyle = FlatStyle.Flat;
            this.btnSender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnSender.ForeColor = Color.White;
            this.btnSender.Location = new Point(60, 260);
            this.btnSender.Name = "btnSender";
            this.btnSender.Size = new Size(240, 50);
            this.btnSender.Text = "Configura Sender";
            this.btnSender.UseVisualStyleBackColor = false;
            this.btnSender.Click += new EventHandler(this.btnSender_Click);

            // pnlReceiver
            this.pnlReceiver.BackColor = Color.FromArgb(230, 255, 240);
            this.pnlReceiver.Controls.Add(this.btnReceiver);
            this.pnlReceiver.Controls.Add(this.lblReceiverDesc);
            this.pnlReceiver.Controls.Add(this.lblReceiverTitle);
            this.pnlReceiver.Dock = DockStyle.Fill;
            this.pnlReceiver.Margin = new Padding(20);
            this.pnlReceiver.Name = "pnlReceiver";
            this.pnlReceiver.Size = new Size(360, 380);
            this.pnlReceiver.TabIndex = 1;

            // lblReceiverTitle
            this.lblReceiverTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblReceiverTitle.ForeColor = Color.FromArgb(0, 130, 60);
            this.lblReceiverTitle.Location = new Point(20, 40);
            this.lblReceiverTitle.Name = "lblReceiverTitle";
            this.lblReceiverTitle.Size = new Size(320, 40);
            this.lblReceiverTitle.Text = "📥  Modalità Receiver";
            this.lblReceiverTitle.TextAlign = ContentAlignment.MiddleCenter;

            // lblReceiverDesc
            this.lblReceiverDesc.Font = new Font("Segoe UI", 10F);
            this.lblReceiverDesc.ForeColor = Color.FromArgb(60, 60, 60);
            this.lblReceiverDesc.Location = new Point(20, 100);
            this.lblReceiverDesc.Name = "lblReceiverDesc";
            this.lblReceiverDesc.Size = new Size(320, 120);
            this.lblReceiverDesc.Text = "Ricevi e analizza email con numeri da verificare.\n\nCarica il CSV dei consensi, configura la casella IMAP e imposta la risposta automatica.";
            this.lblReceiverDesc.TextAlign = ContentAlignment.TopCenter;

            // btnReceiver
            this.btnReceiver.BackColor = Color.FromArgb(0, 160, 80);
            this.btnReceiver.FlatStyle = FlatStyle.Flat;
            this.btnReceiver.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnReceiver.ForeColor = Color.White;
            this.btnReceiver.Location = new Point(60, 260);
            this.btnReceiver.Name = "btnReceiver";
            this.btnReceiver.Size = new Size(240, 50);
            this.btnReceiver.Text = "Configura Receiver";
            this.btnReceiver.UseVisualStyleBackColor = false;
            this.btnReceiver.Click += new EventHandler(this.btnReceiver_Click);

            // statusStrip
            this.statusStrip.Items.AddRange(new ToolStripItem[] { this.tsslStatus });
            this.statusStrip.Location = new Point(0, 420);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new Size(800, 22);
            this.statusStrip.TabIndex = 1;
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Text = "Pronto";

            // lblVersion
            this.lblVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblVersion.Font = new Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = Color.Gray;
            this.lblVersion.Location = new Point(680, 4);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new Size(110, 20);
            this.lblVersion.Text = "AutoCons v1.0";
            this.lblVersion.TextAlign = ContentAlignment.MiddleRight;

            // MainForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 442);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.Font = new Font("Segoe UI", 9F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "AutoCons - Verifica Consensi Telefonici";

            this.tableLayoutPanel.ResumeLayout(false);
            this.pnlSender.ResumeLayout(false);
            this.pnlReceiver.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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

