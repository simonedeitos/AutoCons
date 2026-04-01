using AutoCons.Forms;

namespace AutoCons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSender_Click(object sender, EventArgs e)
        {
            using var form = new SenderConfigForm();
            form.ShowDialog(this);
        }

        private void btnReceiver_Click(object sender, EventArgs e)
        {
            using var form = new ReceiverConfigForm();
            form.ShowDialog(this);
        }
    }
}
