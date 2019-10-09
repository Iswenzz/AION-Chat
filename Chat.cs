using System;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Iswenzz.AION.Notifier
{
    public partial class Chat : Form
    {
        /// <summary>
        /// <see cref="Chat"/> images resources.
        /// </summary>
        public ComponentResourceManager Resources { get; private set; }

        /// <summary>
        /// Dictionary containing all chats.
        /// </summary>
        public Dictionary<string, ConsoleControl.ConsoleControl> Chats { get; private set; }

        public string ChatLogPath { get; set; }
        public StreamReader FileStream { get; private set; }
        public FileSystemWatcher ChatLogWatcher { get; set; }
        private FileStream File { get; set; }
        private ConsoleControl.ConsoleControl SelectedChat { get; set; }

        public bool HasSoundNotif { get; set; } = true;

        /// <summary>
        /// Initialize a new <see cref="Chat"/> instance.
        /// </summary>
        public Chat()
        {
            InitializeComponent();
            ChatLogPath = @"D:\Program Files (x86)\GameforgeLive\Games\FRA_fra\AION\Download\Chat.log";
            Resources = new ComponentResourceManager(typeof(Chat));
            Chats = new Dictionary<string, ConsoleControl.ConsoleControl>
            {
                { "All", CreateChat() },
                { "LFG", CreateChat() },
                { "PM", CreateChat() },
            };
            ToggleChat(Chats["All"]);

            SyncChatLog();
        }

        /// <summary>
        /// Switch chat window.
        /// </summary>
        /// <param name="chat">Selected chat.</param>
        public void ToggleChat(ConsoleControl.ConsoleControl chat)
        {
            foreach (ConsoleControl.ConsoleControl c in Chats.Values)
                c.Hide();

            chat.Show();
            SelectedChat = chat;
        }

        /// <summary>
        /// Create a new chat control.
        /// </summary>
        /// <returns></returns>
        private ConsoleControl.ConsoleControl CreateChat()
        {
            ConsoleControl.ConsoleControl chat = new ConsoleControl.ConsoleControl
            {
                IsInputEnabled = false,
                Margin = new Padding(4),
                Font = new Font("Consolas", 10, FontStyle.Regular),
                SendKeyboardCommandsToProcess = false,
                ShowDiagnostics = false,
                Dock = DockStyle.Fill
            };
            ChatPanel.Controls.Add(chat);
            return chat;
        }

        /// <summary>
        /// Sync aion chat.log.
        /// </summary>
        private void SyncChatLog()
        {
            File = new FileStream(ChatLogPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            FileStream = new StreamReader(File, Encoding.Default);
            FileStream.ReadToEnd();

            ChatLogWatcher = new FileSystemWatcher
            {
                Path = Path.GetDirectoryName(ChatLogPath),
                NotifyFilter = NotifyFilters.LastWrite,
                Filter = "Chat.log",
                EnableRaisingEvents = true
            };
            ChatLogWatcher.Changed += ChatLog_Changed;
        }

        /// <summary>
        /// Callback on chat.log changes.
        /// </summary>
        private void ChatLog_Changed(object sender, FileSystemEventArgs e)
        {
            for (string line = FileStream.ReadLine(); line != null; line = FileStream.ReadLine())
            {
                if (!string.IsNullOrEmpty(line))
                    WriteParsedLine(line);
            }
        }

        /// <summary>
        /// Parse chat.log line to show in the right <see cref="ConsoleControl.ConsoleControl"/>.
        /// </summary>
        /// <param name="line">Chat.log line.</param>
        private void WriteParsedLine(string line)
        {
            Color chatColor = Color.DarkGray;
            ConsoleControl.ConsoleControl chat = null;

            switch (true)
            {
                case true when line.Contains("1.0000 0.6941 0.6941]"):
                    chat = Chats["LFG"];
                    chatColor = Color.FromArgb((int)(1.0000f * 255), (int)(0.6941f * 255), (int)(0.6941f * 255));
                    break;

                case true when line.Contains("0.6275 1.0000 0.6275]"):
                    chat = Chats["PM"];
                    chatColor = Color.FromArgb((int)(0.6275f * 255), (int)(1.0000f * 255), (int)(0.6275f * 255));
                    break;
            }

            // Write to the main channel
            if (Chats["All"].IsHandleCreated)
                Chats["All"].Invoke((Action)(() => Chats["All"].WriteOutput(line + "\n", chatColor)));

            // Write to the right channel
            if (chat != null && chat.IsHandleCreated)
                chat.Invoke((Action)(() => chat.WriteOutput(line + "\n", chatColor)));
        }

        /// <summary>
        /// Toggle chat trigger sounds.
        /// </summary>
        private void MuteButton_Click(object sender, EventArgs e)
        {
            HasSoundNotif = !HasSoundNotif;
            MuteButton.BackgroundImage = HasSoundNotif
                ? (Image)Resources.GetObject("unmuted")
                : (Image)Resources.GetObject("muted");
        }

        /// <summary>
        /// Clear current chat output.
        /// </summary>
        private void CleanButton_Click(object sender, EventArgs e) => SelectedChat?.ClearOutput();

        /// <summary>
        /// Dispose all resources.
        /// </summary>
        public new void Dispose()
        {
            foreach (ConsoleControl.ConsoleControl chat in Chats.Values)
                chat?.Dispose();
            SelectedChat = null;
            Chats = null;
            ChatLogWatcher?.Dispose();
            ChatLogWatcher = null;
            FileStream?.Dispose();
            FileStream = null;
            File?.Dispose();
            File = null;

            base.Dispose();
        }

        private void ButtonAll_Click(object sender, EventArgs e) => ToggleChat(Chats["All"]);
        private void ButtonLFG_Click(object sender, EventArgs e) => ToggleChat(Chats["LFG"]);
        private void ButtonPM_Click(object sender, EventArgs e) => ToggleChat(Chats["PM"]);
    }
}
