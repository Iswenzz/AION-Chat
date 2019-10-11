namespace Iswenzz.AION.Notifier
{
    partial class BanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanForm));
            this.BanBox = new System.Windows.Forms.CheckedListBox();
            this.AddButton = new Iswenzz.UI.Controls.Buttons.FlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveButton = new Iswenzz.UI.Controls.Buttons.FlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // BanBox
            // 
            this.BanBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BanBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BanBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BanBox.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BanBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.BanBox.FormattingEnabled = true;
            this.BanBox.Location = new System.Drawing.Point(0, 0);
            this.BanBox.Name = "BanBox";
            this.BanBox.Size = new System.Drawing.Size(506, 402);
            this.BanBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Angles = 0;
            this.AddButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddButton.HoverColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.HoverColorLeave = System.Drawing.Color.Empty;
            this.AddButton.HoverColorText = System.Drawing.Color.DarkOrange;
            this.AddButton.HoverColorTextLeave = System.Drawing.Color.Empty;
            this.AddButton.Icon = null;
            this.AddButton.IconAutoPlacement = false;
            this.AddButton.IconSize = 0;
            this.AddButton.Location = new System.Drawing.Point(82, 8);
            this.AddButton.Name = "AddButton";
            this.AddButton.RoundedCorner = 0;
            this.AddButton.Size = new System.Drawing.Size(70, 24);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RemoveButton);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(347, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 39);
            this.panel2.TabIndex = 3;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Angles = 0;
            this.RemoveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveButton.HoverColor = System.Drawing.Color.RoyalBlue;
            this.RemoveButton.HoverColorLeave = System.Drawing.Color.Empty;
            this.RemoveButton.HoverColorText = System.Drawing.Color.DarkOrange;
            this.RemoveButton.HoverColorTextLeave = System.Drawing.Color.Empty;
            this.RemoveButton.Icon = null;
            this.RemoveButton.IconAutoPlacement = false;
            this.RemoveButton.IconSize = 0;
            this.RemoveButton.Location = new System.Drawing.Point(7, 8);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.RoundedCorner = 0;
            this.RemoveButton.Size = new System.Drawing.Size(70, 24);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 402);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 39);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 30);
            this.panel4.TabIndex = 4;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.LightGray;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.ForeColor = System.Drawing.Color.Black;
            this.TextBox.Location = new System.Drawing.Point(0, 0);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(347, 22);
            this.TextBox.TabIndex = 4;
            // 
            // BanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(506, 441);
            this.Controls.Add(this.BanBox);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BanForm";
            this.Text = "Ban Messages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BanForm_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.CheckedListBox BanBox;
        private UI.Controls.Buttons.FlatButton AddButton;
        private System.Windows.Forms.Panel panel2;
        private UI.Controls.Buttons.FlatButton RemoveButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Panel panel4;
    }
}