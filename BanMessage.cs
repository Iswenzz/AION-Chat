using System;
using System.Windows.Forms;

namespace Iswenzz.AION.Notifier
{
    public partial class BanForm : Form
    {
        public BanForm()
        {
            InitializeComponent();
            Hide();
        }

        private void BanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox.Text))
                BanBox.Items.Add(TextBox.Text);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (BanBox.SelectedIndex >= 0)
                BanBox.Items.RemoveAt(BanBox.SelectedIndex);
        }
    }
}
