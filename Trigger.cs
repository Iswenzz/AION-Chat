using System;
using System.Windows.Forms;

namespace Iswenzz.AION.Notifier
{
    public partial class TriggerForm : Form
    {
        public TriggerForm()
        {
            InitializeComponent();
            Hide();
        }

        private void TriggerForm_FormClosing(object sender, FormClosingEventArgs e)
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
                TriggerBox.Items.Add(TextBox.Text);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (TriggerBox.SelectedIndex >= 0)
                TriggerBox.Items.RemoveAt(TriggerBox.SelectedIndex);
        }
    }
}
