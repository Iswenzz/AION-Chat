namespace AION.Chat
{
    partial class TriggerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriggerForm));
            panel3 = new System.Windows.Forms.Panel();
            TextBox = new System.Windows.Forms.TextBox();
            panel5 = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            RemoveButton = new IzUI.WinForms.UI.Controls.Inputs.Button();
            AddButton = new IzUI.WinForms.UI.Controls.Inputs.Button();
            panel6 = new System.Windows.Forms.Panel();
            TriggerBox = new System.Windows.Forms.ListView();
            panel10 = new System.Windows.Forms.Panel();
            panel9 = new System.Windows.Forms.Panel();
            panel8 = new System.Windows.Forms.Panel();
            panel7 = new System.Windows.Forms.Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            panel3.Controls.Add(TextBox);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(0, 583);
            panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(618, 81);
            panel3.TabIndex = 6;
            // 
            // TextBox
            // 
            TextBox.BackColor = System.Drawing.Color.LightGray;
            TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            TextBox.ForeColor = System.Drawing.Color.Black;
            TextBox.Location = new System.Drawing.Point(16, 27);
            TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new System.Drawing.Size(318, 29);
            TextBox.TabIndex = 4;
            TextBox.KeyPress += TextBox_KeyPress;
            // 
            // panel5
            // 
            panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel5.Location = new System.Drawing.Point(16, 56);
            panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(318, 25);
            panel5.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(16, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(318, 27);
            panel1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(16, 81);
            panel4.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(RemoveButton);
            panel2.Controls.Add(AddButton);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(334, 0);
            panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(284, 81);
            panel2.TabIndex = 3;
            // 
            // RemoveButton
            // 
            RemoveButton.Alpha.Enabled = true;
            RemoveButton.Animations.BackgroundImageHover = null;
            RemoveButton.Animations.ColorHover = System.Drawing.Color.RoyalBlue;
            RemoveButton.Animations.CursorHover = System.Windows.Forms.Cursors.Hand;
            RemoveButton.Animations.Enabled = true;
            RemoveButton.Animations.TextColorHover = System.Drawing.Color.WhiteSmoke;
            RemoveButton.BackColor = System.Drawing.Color.DodgerBlue;
            RemoveButton.Border.Color = System.Drawing.Color.SteelBlue;
            RemoveButton.Border.Enabled = true;
            RemoveButton.Border.Radius = new System.Drawing.Size(0, 0);
            RemoveButton.Border.Width = 4F;
            RemoveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            RemoveButton.Icon.Enabled = true;
            RemoveButton.Icon.IconImage = null;
            RemoveButton.Icon.IconSize = 0;
            RemoveButton.Layouts.Angle = 0;
            RemoveButton.Layouts.Enabled = true;
            RemoveButton.Location = new System.Drawing.Point(13, 17);
            RemoveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new System.Drawing.Size(125, 50);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.TextLayouts.Angle = 0;
            RemoveButton.TextLayouts.ContentAlign = System.Drawing.ContentAlignment.MiddleCenter;
            RemoveButton.TextLayouts.Enabled = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Alpha.Enabled = true;
            AddButton.Animations.BackgroundImageHover = null;
            AddButton.Animations.ColorHover = System.Drawing.Color.RoyalBlue;
            AddButton.Animations.CursorHover = System.Windows.Forms.Cursors.Hand;
            AddButton.Animations.Enabled = true;
            AddButton.Animations.TextColorHover = System.Drawing.Color.WhiteSmoke;
            AddButton.BackColor = System.Drawing.Color.DodgerBlue;
            AddButton.Border.Color = System.Drawing.Color.SteelBlue;
            AddButton.Border.Enabled = true;
            AddButton.Border.Radius = new System.Drawing.Size(0, 0);
            AddButton.Border.Width = 4F;
            AddButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            AddButton.Icon.Enabled = true;
            AddButton.Icon.IconImage = null;
            AddButton.Icon.IconSize = 0;
            AddButton.Layouts.Angle = 0;
            AddButton.Layouts.Enabled = true;
            AddButton.Location = new System.Drawing.Point(146, 17);
            AddButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(125, 50);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.TextLayouts.Angle = 0;
            AddButton.TextLayouts.ContentAlign = System.Drawing.ContentAlignment.MiddleCenter;
            AddButton.TextLayouts.Enabled = true;
            AddButton.Click += AddButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(TriggerBox);
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            panel6.Location = new System.Drawing.Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(618, 583);
            panel6.TabIndex = 7;
            // 
            // TriggerBox
            // 
            TriggerBox.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            TriggerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TriggerBox.CheckBoxes = true;
            TriggerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            TriggerBox.ForeColor = System.Drawing.Color.Gainsboro;
            TriggerBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            TriggerBox.Location = new System.Drawing.Point(16, 16);
            TriggerBox.Margin = new System.Windows.Forms.Padding(100);
            TriggerBox.Name = "TriggerBox";
            TriggerBox.Size = new System.Drawing.Size(586, 551);
            TriggerBox.TabIndex = 8;
            TriggerBox.UseCompatibleStateImageBehavior = false;
            TriggerBox.View = System.Windows.Forms.View.List;
            TriggerBox.KeyUp += TriggerBox_KeyUp;
            // 
            // panel10
            // 
            panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel10.Location = new System.Drawing.Point(16, 567);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(586, 16);
            panel10.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Dock = System.Windows.Forms.DockStyle.Top;
            panel9.Location = new System.Drawing.Point(16, 0);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(586, 16);
            panel9.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Dock = System.Windows.Forms.DockStyle.Right;
            panel8.Location = new System.Drawing.Point(602, 0);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(16, 583);
            panel8.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Dock = System.Windows.Forms.DockStyle.Left;
            panel7.Location = new System.Drawing.Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(16, 583);
            panel7.TabIndex = 0;
            // 
            // TriggerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            ClientSize = new System.Drawing.Size(618, 664);
            Controls.Add(panel6);
            Controls.Add(panel3);
            ForeColor = System.Drawing.Color.Gainsboro;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "TriggerForm";
            Text = "Triggers";
            FormClosing += TriggerForm_FormClosing;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private IzUI.WinForms.UI.Controls.Inputs.Button RemoveButton;
        private IzUI.WinForms.UI.Controls.Inputs.Button AddButton;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.ListView TriggerBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
    }
}