namespace AION.Chat
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
            panel1 = new System.Windows.Forms.Panel();
            ButtonPM = new System.Windows.Forms.Button();
            ButtonTrigger = new System.Windows.Forms.Button();
            ButtonLFG = new System.Windows.Forms.Button();
            ButtonBan = new System.Windows.Forms.Button();
            ButtonAll = new System.Windows.Forms.Button();
            ButtonMute = new System.Windows.Forms.Button();
            ButtonClear = new System.Windows.Forms.Button();
            ButtonLog = new System.Windows.Forms.Button();
            panel3 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel5 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            ChatPanel = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            panel1.Controls.Add(ButtonPM);
            panel1.Controls.Add(ButtonTrigger);
            panel1.Controls.Add(ButtonLFG);
            panel1.Controls.Add(ButtonBan);
            panel1.Controls.Add(ButtonAll);
            panel1.Controls.Add(ButtonMute);
            panel1.Controls.Add(ButtonClear);
            panel1.Controls.Add(ButtonLog);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1006, 50);
            panel1.TabIndex = 0;
            // 
            // ButtonPM
            // 
            ButtonPM.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            ButtonPM.Dock = System.Windows.Forms.DockStyle.Left;
            ButtonPM.FlatAppearance.BorderSize = 0;
            ButtonPM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ButtonPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonPM.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ButtonPM.ForeColor = System.Drawing.Color.WhiteSmoke;
            ButtonPM.Location = new System.Drawing.Point(258, 8);
            ButtonPM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonPM.Name = "ButtonPM";
            ButtonPM.Size = new System.Drawing.Size(125, 34);
            ButtonPM.TabIndex = 2;
            ButtonPM.Text = "PM";
            ButtonPM.UseVisualStyleBackColor = false;
            ButtonPM.Click += ButtonPM_Click;
            // 
            // ButtonTrigger
            // 
            ButtonTrigger.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            ButtonTrigger.BackgroundImage = Properties.Resources.trigger;
            ButtonTrigger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonTrigger.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonTrigger.Dock = System.Windows.Forms.DockStyle.Right;
            ButtonTrigger.FlatAppearance.BorderSize = 0;
            ButtonTrigger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ButtonTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonTrigger.ForeColor = System.Drawing.Color.WhiteSmoke;
            ButtonTrigger.Location = new System.Drawing.Point(798, 8);
            ButtonTrigger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonTrigger.Name = "ButtonTrigger";
            ButtonTrigger.Size = new System.Drawing.Size(40, 34);
            ButtonTrigger.TabIndex = 2;
            ButtonTrigger.TabStop = false;
            ButtonTrigger.UseVisualStyleBackColor = false;
            ButtonTrigger.Click += ButtonTrigger_Click;
            // 
            // ButtonLFG
            // 
            ButtonLFG.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            ButtonLFG.Dock = System.Windows.Forms.DockStyle.Left;
            ButtonLFG.FlatAppearance.BorderSize = 0;
            ButtonLFG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ButtonLFG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonLFG.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ButtonLFG.ForeColor = System.Drawing.Color.WhiteSmoke;
            ButtonLFG.Location = new System.Drawing.Point(133, 8);
            ButtonLFG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonLFG.Name = "ButtonLFG";
            ButtonLFG.Size = new System.Drawing.Size(125, 34);
            ButtonLFG.TabIndex = 1;
            ButtonLFG.Text = "LFG";
            ButtonLFG.UseVisualStyleBackColor = false;
            ButtonLFG.Click += ButtonLFG_Click;
            // 
            // ButtonBan
            // 
            ButtonBan.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            ButtonBan.BackgroundImage = Properties.Resources.ban;
            ButtonBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonBan.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonBan.Dock = System.Windows.Forms.DockStyle.Right;
            ButtonBan.FlatAppearance.BorderSize = 0;
            ButtonBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ButtonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonBan.ForeColor = System.Drawing.Color.WhiteSmoke;
            ButtonBan.Location = new System.Drawing.Point(838, 8);
            ButtonBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonBan.Name = "ButtonBan";
            ButtonBan.Size = new System.Drawing.Size(40, 34);
            ButtonBan.TabIndex = 3;
            ButtonBan.TabStop = false;
            ButtonBan.UseVisualStyleBackColor = false;
            ButtonBan.Click += ButtonBan_Click;
            // 
            // ButtonAll
            // 
            ButtonAll.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            ButtonAll.Dock = System.Windows.Forms.DockStyle.Left;
            ButtonAll.FlatAppearance.BorderSize = 0;
            ButtonAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ButtonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonAll.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            ButtonAll.ForeColor = System.Drawing.Color.WhiteSmoke;
            ButtonAll.Location = new System.Drawing.Point(8, 8);
            ButtonAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonAll.Name = "ButtonAll";
            ButtonAll.Size = new System.Drawing.Size(125, 34);
            ButtonAll.TabIndex = 0;
            ButtonAll.Text = "All";
            ButtonAll.UseVisualStyleBackColor = false;
            ButtonAll.Click += ButtonAll_Click;
            // 
            // ButtonMute
            // 
            ButtonMute.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            ButtonMute.BackgroundImage = Properties.Resources.unmuted;
            ButtonMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonMute.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonMute.Dock = System.Windows.Forms.DockStyle.Right;
            ButtonMute.FlatAppearance.BorderSize = 0;
            ButtonMute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ButtonMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonMute.ForeColor = System.Drawing.Color.WhiteSmoke;
            ButtonMute.Location = new System.Drawing.Point(878, 8);
            ButtonMute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonMute.Name = "ButtonMute";
            ButtonMute.Size = new System.Drawing.Size(40, 34);
            ButtonMute.TabIndex = 0;
            ButtonMute.TabStop = false;
            ButtonMute.UseVisualStyleBackColor = false;
            ButtonMute.Click += ButtonMute_Click;
            // 
            // ButtonClear
            // 
            ButtonClear.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            ButtonClear.BackgroundImage = Properties.Resources.erase;
            ButtonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonClear.Dock = System.Windows.Forms.DockStyle.Right;
            ButtonClear.FlatAppearance.BorderSize = 0;
            ButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonClear.ForeColor = System.Drawing.Color.WhiteSmoke;
            ButtonClear.Location = new System.Drawing.Point(918, 8);
            ButtonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new System.Drawing.Size(40, 34);
            ButtonClear.TabIndex = 1;
            ButtonClear.TabStop = false;
            ButtonClear.UseVisualStyleBackColor = false;
            ButtonClear.Click += ButtonClean_Click;
            // 
            // ButtonLog
            // 
            ButtonLog.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            ButtonLog.BackgroundImage = Properties.Resources.log;
            ButtonLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ButtonLog.Cursor = System.Windows.Forms.Cursors.Hand;
            ButtonLog.Dock = System.Windows.Forms.DockStyle.Right;
            ButtonLog.FlatAppearance.BorderSize = 0;
            ButtonLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            ButtonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            ButtonLog.Location = new System.Drawing.Point(958, 8);
            ButtonLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ButtonLog.Name = "ButtonLog";
            ButtonLog.Size = new System.Drawing.Size(40, 34);
            ButtonLog.TabIndex = 5;
            ButtonLog.TabStop = false;
            ButtonLog.UseVisualStyleBackColor = false;
            ButtonLog.Click += ButtonLog_Click;
            // 
            // panel3
            // 
            panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel3.Location = new System.Drawing.Point(8, 42);
            panel3.Margin = new System.Windows.Forms.Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(990, 8);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(8, 0);
            panel4.Margin = new System.Windows.Forms.Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(990, 8);
            panel4.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Dock = System.Windows.Forms.DockStyle.Right;
            panel5.Location = new System.Drawing.Point(998, 0);
            panel5.Margin = new System.Windows.Forms.Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(8, 50);
            panel5.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Dock = System.Windows.Forms.DockStyle.Left;
            panel2.Location = new System.Drawing.Point(0, 0);
            panel2.Margin = new System.Windows.Forms.Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(8, 50);
            panel2.TabIndex = 9;
            // 
            // ChatPanel
            // 
            ChatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ChatPanel.Location = new System.Drawing.Point(0, 50);
            ChatPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            ChatPanel.Name = "ChatPanel";
            ChatPanel.Size = new System.Drawing.Size(1006, 481);
            ChatPanel.TabIndex = 2;
            // 
            // Chat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            ClientSize = new System.Drawing.Size(1006, 531);
            Controls.Add(ChatPanel);
            Controls.Add(panel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Chat";
            Text = "AION Chat";
            FormClosing += Chat_FormClosing;
            Load += Chat_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonMute;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonAll;
        private System.Windows.Forms.Button ButtonLFG;
        private System.Windows.Forms.Button ButtonPM;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.Button ButtonTrigger;
        private System.Windows.Forms.Button ButtonBan;
        private System.Windows.Forms.Button ButtonLog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
    }
}

