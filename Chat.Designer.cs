namespace Iswenzz.AION.Notifier
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearButton = new Iswenzz.UI.Controls.Buttons.FlatButton();
            this.MuteButton = new Iswenzz.UI.Controls.Buttons.FlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonPM = new Iswenzz.UI.Controls.Buttons.FlatButton();
            this.ButtonLFG = new Iswenzz.UI.Controls.Buttons.FlatButton();
            this.ButtonAll = new Iswenzz.UI.Controls.Buttons.FlatButton();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.MuteButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 45);
            this.panel1.TabIndex = 0;
            // 
            // ClearButton
            // 
            this.ClearButton.Angles = 0;
            this.ClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("erase")));
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ClearButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClearButton.HoverColorLeave = System.Drawing.Color.Empty;
            this.ClearButton.HoverColorText = System.Drawing.Color.DarkOrange;
            this.ClearButton.HoverColorTextLeave = System.Drawing.Color.Empty;
            this.ClearButton.Icon = null;
            this.ClearButton.IconAutoPlacement = false;
            this.ClearButton.IconSize = 0;
            this.ClearButton.Location = new System.Drawing.Point(750, 0);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.RoundedCorner = 0;
            this.ClearButton.Size = new System.Drawing.Size(48, 43);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // MuteButton
            // 
            this.MuteButton.Angles = 0;
            this.MuteButton.BackColor = System.Drawing.Color.Transparent;
            this.MuteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unmuted")));
            this.MuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MuteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MuteButton.FlatAppearance.BorderSize = 0;
            this.MuteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MuteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MuteButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MuteButton.HoverColorLeave = System.Drawing.Color.Empty;
            this.MuteButton.HoverColorText = System.Drawing.Color.DarkOrange;
            this.MuteButton.HoverColorTextLeave = System.Drawing.Color.Empty;
            this.MuteButton.Icon = null;
            this.MuteButton.IconAutoPlacement = false;
            this.MuteButton.IconSize = 0;
            this.MuteButton.Location = new System.Drawing.Point(0, 0);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.RoundedCorner = 0;
            this.MuteButton.Size = new System.Drawing.Size(48, 43);
            this.MuteButton.TabIndex = 0;
            this.MuteButton.UseVisualStyleBackColor = false;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ButtonPM);
            this.panel2.Controls.Add(this.ButtonLFG);
            this.panel2.Controls.Add(this.ButtonAll);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 24);
            this.panel2.TabIndex = 1;
            // 
            // ButtonPM
            // 
            this.ButtonPM.Angles = 0;
            this.ButtonPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonPM.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonPM.FlatAppearance.BorderSize = 0;
            this.ButtonPM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPM.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonPM.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ButtonPM.HoverColorLeave = System.Drawing.Color.Empty;
            this.ButtonPM.HoverColorText = System.Drawing.Color.DarkOrange;
            this.ButtonPM.HoverColorTextLeave = System.Drawing.Color.Empty;
            this.ButtonPM.Icon = null;
            this.ButtonPM.IconAutoPlacement = false;
            this.ButtonPM.IconSize = 0;
            this.ButtonPM.Location = new System.Drawing.Point(250, 0);
            this.ButtonPM.Name = "ButtonPM";
            this.ButtonPM.RoundedCorner = 0;
            this.ButtonPM.Size = new System.Drawing.Size(125, 22);
            this.ButtonPM.TabIndex = 2;
            this.ButtonPM.Text = "PM";
            this.ButtonPM.UseVisualStyleBackColor = false;
            this.ButtonPM.Click += new System.EventHandler(this.ButtonPM_Click);
            // 
            // ButtonLFG
            // 
            this.ButtonLFG.Angles = 0;
            this.ButtonLFG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonLFG.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonLFG.FlatAppearance.BorderSize = 0;
            this.ButtonLFG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonLFG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonLFG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLFG.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLFG.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonLFG.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ButtonLFG.HoverColorLeave = System.Drawing.Color.Empty;
            this.ButtonLFG.HoverColorText = System.Drawing.Color.DarkOrange;
            this.ButtonLFG.HoverColorTextLeave = System.Drawing.Color.Empty;
            this.ButtonLFG.Icon = null;
            this.ButtonLFG.IconAutoPlacement = false;
            this.ButtonLFG.IconSize = 0;
            this.ButtonLFG.Location = new System.Drawing.Point(125, 0);
            this.ButtonLFG.Name = "ButtonLFG";
            this.ButtonLFG.RoundedCorner = 0;
            this.ButtonLFG.Size = new System.Drawing.Size(125, 22);
            this.ButtonLFG.TabIndex = 1;
            this.ButtonLFG.Text = "LFG";
            this.ButtonLFG.UseVisualStyleBackColor = false;
            this.ButtonLFG.Click += new System.EventHandler(this.ButtonLFG_Click);
            // 
            // ButtonAll
            // 
            this.ButtonAll.Angles = 0;
            this.ButtonAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ButtonAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonAll.FlatAppearance.BorderSize = 0;
            this.ButtonAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAll.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAll.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ButtonAll.HoverColorLeave = System.Drawing.Color.Empty;
            this.ButtonAll.HoverColorText = System.Drawing.Color.DarkOrange;
            this.ButtonAll.HoverColorTextLeave = System.Drawing.Color.Empty;
            this.ButtonAll.Icon = null;
            this.ButtonAll.IconAutoPlacement = false;
            this.ButtonAll.IconSize = 0;
            this.ButtonAll.Location = new System.Drawing.Point(0, 0);
            this.ButtonAll.Name = "ButtonAll";
            this.ButtonAll.RoundedCorner = 0;
            this.ButtonAll.Size = new System.Drawing.Size(125, 22);
            this.ButtonAll.TabIndex = 0;
            this.ButtonAll.Text = "All";
            this.ButtonAll.UseVisualStyleBackColor = false;
            this.ButtonAll.Click += new System.EventHandler(this.ButtonAll_Click);
            // 
            // ChatPanel
            // 
            this.ChatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatPanel.Location = new System.Drawing.Point(0, 69);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(800, 381);
            this.ChatPanel.TabIndex = 2;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Chat";
            this.Text = "Aion Chat Notif";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Iswenzz.UI.Controls.Buttons.FlatButton MuteButton;
        private Iswenzz.UI.Controls.Buttons.FlatButton ClearButton;
        private System.Windows.Forms.Panel panel2;
        private UI.Controls.Buttons.FlatButton ButtonAll;
        private UI.Controls.Buttons.FlatButton ButtonLFG;
        private UI.Controls.Buttons.FlatButton ButtonPM;
        private System.Windows.Forms.Panel ChatPanel;
    }
}

