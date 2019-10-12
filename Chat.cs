using System;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Threading.Tasks;

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

        private TriggerForm TriggerForm { get; set; }
        private BanForm BanForm { get; set; }

        public string ChatLogPath { get; set; }
        public StreamReader Reader { get; private set; }
        public FileSystemWatcher ChatLogWatcher { get; set; }
        private FileStream FS { get; set; }
        private ConsoleControl.ConsoleControl SelectedChat { get; set; }
        private HtmlWeb Web { get; set; }

        public bool HasSoundNotif { get; set; } = true;
        private bool IsSoundPlaying { get; set; }

        /// <summary>
        /// Initialize a new <see cref="Chat"/> instance.
        /// </summary>
        public Chat()
        {
            InitializeComponent();
            Resources = new ComponentResourceManager(typeof(Resources));
            Web = new HtmlWeb();
            TriggerForm = new TriggerForm();
            BanForm = new BanForm();

            Chats = new Dictionary<string, ConsoleControl.ConsoleControl>
            {
                { "All", CreateChat() },
                { "LFG", CreateChat() },
                { "PM", CreateChat() },
            };
            SelectedChat = Chats["All"];
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
            FS?.Dispose();
            Reader?.Dispose();
            ChatLogWatcher?.Dispose();

            if (!string.IsNullOrEmpty(ChatLogPath) && !File.Exists(ChatLogPath))
            {
                ChatLogPath = "";
                return;
            }

            FS = new FileStream(ChatLogPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            Reader = new StreamReader(FS, Encoding.Default);
            Reader.ReadToEnd();

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
            for (string line = Reader.ReadLine(); line != null; line = Reader.ReadLine())
            {
                if (!string.IsNullOrEmpty(line))
                    try { ProcessLine(line); } catch (Exception ex) { Console.WriteLine(ex); }
            }
        }

        /// <summary>
        /// Parse and edit chat.log line to show in the right <see cref="ConsoleControl.ConsoleControl"/>.
        /// </summary>
        /// <param name="line">Chat.log line.</param>
        private void ProcessLine(string line)
        {
            Color chatColor = Color.DarkGray;
            ConsoleControl.ConsoleControl chat = null;

            switch (true)
            {
                case true when line.Contains("[3.LFG] [charname:"):
                    chat = Chats["LFG"];
                    chatColor = Color.FromArgb((int)(1.0000f * 255), (int)(0.6941f * 255), (int)(0.6941f * 255));
                    break;

                case true when line.Contains("Whispers:"):
                case true when line.Contains("You Whisper to [charname:"):
                    chat = Chats["PM"];
                    chatColor = Color.FromArgb((int)(0.6275f * 255), (int)(1.0000f * 255), (int)(0.6275f * 255));
                    break;

                case true when line.Contains("You shout \""):
                    chatColor = Color.Sienna;
                    break;
            }
            // Parse and write log date
            ProcessDate(ref line, chat);
            // Parse and edit links
            ProcessLinks(ref line, chat);
            // Print edited line
            Print(line + "\n", chatColor, chat);
            // Notify
            Task.Factory.StartNew(() => CheckNotify(line));
        }

        /// <summary>
        /// Check if the line is in the trigger list.
        /// </summary>
        /// <param name="line">Chat.log line.</param>
        private async Task CheckNotify(string line)
        {
            if (string.IsNullOrEmpty(line))
                return;

            if (TriggerForm.TriggerBox.Items.Cast<ListViewItem>().Where(b => b.Checked).Any(b => line.Contains(b.Text))
                && !BanForm.BanBox.Items.Cast<ListViewItem>().Where(b => b.Checked).Any(b => line.Contains(b.Text)))
            {
                using (NotifyIcon notifyIcon = new NotifyIcon { Visible = true, Icon = SystemIcons.Application })
                {
                    string trigMessage = TriggerForm.TriggerBox.Items.Cast<ListViewItem>()
                        .Where(b => b.Checked).FirstOrDefault(b => line.Contains(b.Text)).Text;

                    notifyIcon.BalloonTipTitle = $"AION Chat Notification [{trigMessage}]";
                    notifyIcon.BalloonTipText = line;

                    notifyIcon.ShowBalloonTip(20 * 1000);

                    if (HasSoundNotif)
                        await NotifySoundLoop();
                }
            }
        }

        /// <summary>
        /// Notify user with a system sound and system tray notification.
        /// </summary>
        private async Task NotifySoundLoop()
        {
            if (IsSoundPlaying)
                return;

            IsSoundPlaying = true;
            for (int i = 0; i < 30; i++)
            {
                if (!HasSoundNotif)
                    break;

                System.Media.SystemSounds.Beep.Play();
                await Task.Delay(1000);
            }
            IsSoundPlaying = false;
        }

        /// <summary>
        /// Parse links and put the right text.
        /// </summary>
        /// <param name="line">Chat.log line.</param>
        public void ProcessLinks(ref string line, ConsoleControl.ConsoleControl chat)
        {
            Regex rgx_link = new Regex(@"(\[.*?:.*?])");
            Match link = rgx_link.Match(line);
            while (link != null && link.Success)
            {
                string link_str = link.Value;
                switch (true)
                {
                    case true when link_str.Contains("item:"):
                        line = line.Remove(link.Index, link.Length);

                        // Get item id from link
                        string item_id = link_str.Split(':')[1];
                        if (item_id.Contains(";"))
                            item_id = item_id.Substring(0, item_id.IndexOf(';'));

                        // Get item name from aioncodex title
                        HtmlAgilityPack.HtmlDocument doc = Web.Load($"https://aioncodex.com/en/item/{item_id}");
                        string item_name = doc.DocumentNode.SelectSingleNode("html/head/title")
                            .InnerText.Replace(" - Aion Codex", "") ?? $"item:{item_id}";
                        link_str = "<" + item_name + ">";
                        line = line.Insert(link.Index, link_str);
                        link = rgx_link.Match(line);
                        continue;

                    case true when link_str.Contains("charname:"):
                        line = line.Remove(link.Index, link.Length);

                        // Get char name from link
                        string char_name = link_str.Split(':')[1];
                        if (char_name.Contains(";"))
                            char_name = char_name.Substring(0, char_name.IndexOf(';'));

                        link_str = char_name;
                        line = line.Insert(link.Index, link_str);
                        link = rgx_link.Match(line);
                        continue;
                }
                link = null;
            }
        }

        /// <summary>
        /// Parse the log date and print in gray color.
        /// </summary>
        /// <param name="line">Chat.log line.</param>
        public void ProcessDate(ref string line, ConsoleControl.ConsoleControl chat)
        {
            Regex rgx_time = new Regex(@"([0-9:]{8})");
            Regex rgx_remove_date = new Regex(@"(.*([0-9:]{8}).* : )");
            string date = "(" + rgx_time.Match(line).Value + ") ";

            // Edit date format
            line = rgx_remove_date.Replace(line, date);
        }

        /// <summary>
        /// Print line to the main channel, (optional) and their own channel.
        /// </summary>
        /// <param name="line">Chat.log line.</param>
        /// <param name="chatColor">Line foreground <see cref="Color"/>.</param>
        /// <param name="chat">Print to this channel aswell.</param>
        public void Print(string line, Color chatColor, ConsoleControl.ConsoleControl chat = null)
        {
            // Write to the main channel
            if (Chats["All"].IsHandleCreated)
                Chats["All"].Invoke((Action)(() => Chats["All"].WriteOutput(line, chatColor)));

            // Write to the right channel
            if (chat != null && chat.IsHandleCreated)
                chat.Invoke((Action)(() => chat.WriteOutput(line, chatColor)));
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
            Reader?.Dispose();
            Reader = null;
            FS?.Dispose();
            FS = null;

            base.Dispose();
        }

        private void ButtonAll_Click(object sender, EventArgs e) => ToggleChat(Chats["All"]);
        private void ButtonLFG_Click(object sender, EventArgs e) => ToggleChat(Chats["LFG"]);
        private void ButtonPM_Click(object sender, EventArgs e) => ToggleChat(Chats["PM"]);
        private void TriggerButton_Click(object sender, EventArgs e) => TriggerForm.Show();
        private void BanButton_Click(object sender, EventArgs e) => BanForm.Show();
        private void LogButton_Click(object sender, EventArgs e) => ChangeLogPath();

        /// <summary>
        /// Change the Chat.log file path.
        /// </summary>
        public void ChangeLogPath()
        {
            using (OpenFileDialog dialog = new OpenFileDialog() { Filter = "Log files (*.log)|*.log|All files (*.*)|*.*", Title = "Chat.log location.", })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ChatLogPath = dialog.FileName;
                    SyncChatLog();
                }
            }
        }

        /// <summary>
        /// Callback on form closing, save triggers/bans etc to user settings.
        /// </summary>
        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save chat log path
            Properties.Settings.Default.LogPath = ChatLogPath;

            // Save triggers
            Properties.Settings.Default.TriggersOn = string.Join(",", TriggerForm.TriggerBox.Items
                .Cast<ListViewItem>().Where(b => b.Checked).Select(b => b.Text));
            Properties.Settings.Default.TriggersOff = string.Join(",", TriggerForm.TriggerBox.Items
                .Cast<ListViewItem>().Where(b => !b.Checked).Select(b => b.Text));

            // Save bans
            Properties.Settings.Default.BanOn = string.Join(",", BanForm.BanBox.Items
                .Cast<ListViewItem>().Where(b => b.Checked).Select(b => b.Text));
            Properties.Settings.Default.BanOff = string.Join(",", BanForm.BanBox.Items
                .Cast<ListViewItem>().Where(b => !b.Checked).Select(b => b.Text));

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Callback on form load, load triggers/bans etc from user settings.
        /// </summary>
        private void Chat_Load(object sender, EventArgs e)
        {
            // Load chat log path
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LogPath))
            {
                ChatLogPath = Properties.Settings.Default.LogPath;
                SyncChatLog();
            }

            // Load triggers
            if (!string.IsNullOrEmpty(Properties.Settings.Default.TriggersOn))
                Properties.Settings.Default.TriggersOn.Split(',').ToList()
                    .ForEach(item => TriggerForm.TriggerBox.Items.Add(new ListViewItem(item) { Checked = true }));
            if (!string.IsNullOrEmpty(Properties.Settings.Default.TriggersOff))
                Properties.Settings.Default.TriggersOff.Split(',').ToList()
                    .ForEach(item => TriggerForm.TriggerBox.Items.Add(new ListViewItem(item) { Checked = false }));

            // Load ban
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BanOn))
                Properties.Settings.Default.BanOn.Split(',').ToList()
                    .ForEach(item => BanForm.BanBox.Items.Add(new ListViewItem(item) { Checked = true }));
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BanOff))
                Properties.Settings.Default.BanOff.Split(',').ToList()
                    .ForEach(item => BanForm.BanBox.Items.Add(new ListViewItem(item) { Checked = false }));
        }
    }
}
