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
        public StreamReader FileStream { get; private set; }
        public FileSystemWatcher ChatLogWatcher { get; set; }
        private FileStream File { get; set; }
        private ConsoleControl.ConsoleControl SelectedChat { get; set; }
        private HtmlWeb Web { get; set; }

        public bool HasSoundNotif { get; set; } = true;

        /// <summary>
        /// Initialize a new <see cref="Chat"/> instance.
        /// </summary>
        public Chat()
        {
            InitializeComponent();
            ChatLogPath = @"D:\Program Files (x86)\GameforgeLive\Games\FRA_fra\AION\Download\Chat.log";
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
                    ProcessLine(line);
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

            if (TriggerForm.TriggerBox.Items.Cast<string>().Any(item => line.Contains(item))
                && !BanForm.BanBox.Items.Cast<string>().Any(item => line.Contains(item)))
            {
                using (NotifyIcon notifyIcon = new NotifyIcon { Visible = true, Icon = SystemIcons.Application })
                {
                    string trigMessage = TriggerForm.TriggerBox.Items.Cast<string>()
                        .FirstOrDefault(item => line.Contains(item));

                    notifyIcon.BalloonTipTitle = $"AION Chat Notification. [{trigMessage}]";
                    notifyIcon.BalloonTipText = line;

                    notifyIcon.ShowBalloonTip(20 * 1000);

                    if (HasSoundNotif)
                        await NotifySoundLoop();
                }
            }
        }

        private async Task NotifySoundLoop()
        {
            for (int i = 0; i < 30; i++)
            {
                if (!HasSoundNotif)
                    break;

                System.Media.SystemSounds.Beep.Play();
                await Task.Delay(1000);
            }
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
                        link_str = "<" + doc.DocumentNode.SelectSingleNode("html/head/title")
                            .InnerText.Replace(" - Aion Codex", "") + ">";
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
        /// Parse the log date and print in gray color.
        /// </summary>
        /// <param name="line">Chat.log line.</param>
        public void ProcessDate(ref string line, ConsoleControl.ConsoleControl chat)
        {
            Regex rgx_time = new Regex(@"([0-9:]{8})");
            Regex rgx_remove_date = new Regex(@"(.*([0-9:]{8}).* : )");
            string date = "(" + rgx_time.Match(line).Value + ") ";

            // Remove date from parsed line
            line = rgx_remove_date.Replace(line, "");
            Print(date, Color.DimGray, chat);
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
        private void TriggerButton_Click(object sender, EventArgs e) => TriggerForm.Show();
        private void BanButton_Click(object sender, EventArgs e) => BanForm.Show();

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save triggers
            List<string> on = new List<string>();
            List<string> off = new List<string>();
            foreach (object item in TriggerForm.TriggerBox.Items)
            {
                if (!TriggerForm.TriggerBox.CheckedItems.Contains(item))
                    off.Add((string)item);
                else
                    on.Add((string)item);
            }
            Properties.Settings.Default.TriggersOn = string.Join(",", on);
            Properties.Settings.Default.TriggersOff = string.Join(",", off);

            // Save bans
            on.Clear();
            off.Clear();
            foreach (object item in BanForm.BanBox.Items)
            {
                if (!BanForm.BanBox.CheckedItems.Contains(item))
                    off.Add((string)item);
                else
                    on.Add((string)item);
            }
            Properties.Settings.Default.BanOn = string.Join(",", on);
            Properties.Settings.Default.BanOff = string.Join(",", off);

            Properties.Settings.Default.Save();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            // Load triggers
            if (!string.IsNullOrEmpty(Properties.Settings.Default.TriggersOn))
            {
                string[] items = Properties.Settings.Default.TriggersOn.Split(',');
                for (int i = 0; i < items.Length; i++)
                {
                    TriggerForm.TriggerBox.Items.Add(items[i]);
                    TriggerForm.TriggerBox.SetItemChecked(i, true);
                }
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.TriggersOff))
            {
                string[] items = Properties.Settings.Default.TriggersOff.Split(',');
                for (int i = 0; i < items.Length; i++)
                    TriggerForm.TriggerBox.Items.Add(items[i]);
            }

            // Load ban
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BanOn))
            {
                string[] items = Properties.Settings.Default.BanOn.Split(',');
                for (int i = 0; i < items.Length; i++)
                {
                    BanForm.BanBox.Items.Add(items[i]);
                    BanForm.BanBox.SetItemChecked(i, true);
                }
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.BanOff))
            {
                string[] items = Properties.Settings.Default.BanOff.Split(',');
                for (int i = 0; i < items.Length; i++)
                    BanForm.BanBox.Items.Add(items[i]);
            }
        }
    }
}
