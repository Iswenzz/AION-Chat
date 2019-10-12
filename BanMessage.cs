using System;
using System.Linq;
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
            if (!string.IsNullOrEmpty(TextBox.Text) 
                && !BanBox.Items.Cast<ListViewItem>().Any(b => b.Text.Contains(TextBox.Text)))
                BanBox.Items.Add(TextBox.Text);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in BanBox.SelectedItems)
                BanBox.Items.Remove(item);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddButton_Click(null, null);
            }
        }

        private void BanBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                RemoveButton_Click(null, null);
            }
        }
    }
}
