using System;
using System.Linq;
using System.Windows.Forms;

namespace Iswenzz.AION.Notifier
{
    public partial class BanForm : Form
    {
        /// <summary>
        /// Initialize a new <see cref="BanForm"/> instance.
        /// </summary>
        public BanForm()
        {
            InitializeComponent();
            Hide();
        }

        /// <summary>
        /// Callback on form closing: hide the form instead of disposing.
        /// </summary>
        private void BanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        /// <summary>
        /// Add a new item to the <see cref="ListView"/>. 
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox.Text) 
                && !BanBox.Items.Cast<ListViewItem>().Any(b => b.Text.Contains(TextBox.Text)))
                BanBox.Items.Add(TextBox.Text);
        }

        /// <summary>
        /// Remove selected items from the <see cref="ListView"/>. 
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in BanBox.SelectedItems)
                BanBox.Items.Remove(item);
        }

        /// <summary>
        /// Textbox keypress callback: hotkey to add the textbox text to the <see cref="ListView"/>.
        /// </summary>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddButton_Click(null, null);
            }
        }

        /// <summary>
        /// <see cref="ListView"/> keyup callback: hotkey to remove selected items.
        /// </summary>
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
