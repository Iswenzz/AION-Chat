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
            RemoveButton = new System.Windows.Forms.Button();
            AddButton = new System.Windows.Forms.Button();
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
            panel3.Location = new System.Drawing.Point(0, 466);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(494, 65);
            panel3.TabIndex = 6;
            // 
            // TextBox
            // 
            TextBox.BackColor = System.Drawing.Color.White;
            TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            TextBox.ForeColor = System.Drawing.Color.Black;
            TextBox.Location = new System.Drawing.Point(13, 22);
            TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TextBox.Multiline = true;
            TextBox.Name = "TextBox";
            TextBox.Size = new System.Drawing.Size(254, 23);
            TextBox.TabIndex = 4;
            TextBox.KeyPress += TextBox_KeyPress;
            // 
            // panel5
            // 
            panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel5.Location = new System.Drawing.Point(13, 45);
            panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(254, 20);
            panel5.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(13, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(254, 22);
            panel1.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Left;
            panel4.Location = new System.Drawing.Point(0, 0);
            panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(13, 65);
            panel4.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(RemoveButton);
            panel2.Controls.Add(AddButton);
            panel2.Dock = System.Windows.Forms.DockStyle.Right;
            panel2.Location = new System.Drawing.Point(267, 0);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(227, 65);
            panel2.TabIndex = 3;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = System.Drawing.Color.DodgerBlue;
            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            RemoveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            RemoveButton.Location = new System.Drawing.Point(10, 14);
            RemoveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new System.Drawing.Size(100, 40);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = System.Drawing.Color.DodgerBlue;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            AddButton.Location = new System.Drawing.Point(117, 14);
            AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(100, 40);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
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
            panel6.Margin = new System.Windows.Forms.Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new System.Drawing.Size(494, 466);
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
            TriggerBox.Location = new System.Drawing.Point(13, 13);
            TriggerBox.Margin = new System.Windows.Forms.Padding(80);
            TriggerBox.Name = "TriggerBox";
            TriggerBox.Size = new System.Drawing.Size(468, 440);
            TriggerBox.TabIndex = 8;
            TriggerBox.UseCompatibleStateImageBehavior = false;
            TriggerBox.View = System.Windows.Forms.View.List;
            TriggerBox.KeyUp += TriggerBox_KeyUp;
            // 
            // panel10
            // 
            panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel10.Location = new System.Drawing.Point(13, 453);
            panel10.Margin = new System.Windows.Forms.Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new System.Drawing.Size(468, 13);
            panel10.TabIndex = 3;
            // 
            // panel9
            // 
            panel9.Dock = System.Windows.Forms.DockStyle.Top;
            panel9.Location = new System.Drawing.Point(13, 0);
            panel9.Margin = new System.Windows.Forms.Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new System.Drawing.Size(468, 13);
            panel9.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Dock = System.Windows.Forms.DockStyle.Right;
            panel8.Location = new System.Drawing.Point(481, 0);
            panel8.Margin = new System.Windows.Forms.Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new System.Drawing.Size(13, 466);
            panel8.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Dock = System.Windows.Forms.DockStyle.Left;
            panel7.Location = new System.Drawing.Point(0, 0);
            panel7.Margin = new System.Windows.Forms.Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(13, 466);
            panel7.TabIndex = 0;
            // 
            // TriggerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            ClientSize = new System.Drawing.Size(494, 531);
            Controls.Add(panel6);
            Controls.Add(panel3);
            ForeColor = System.Drawing.Color.Gainsboro;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.ListView TriggerBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
    }
}