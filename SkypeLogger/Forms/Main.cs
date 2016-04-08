using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SkypeLogger.Classes;
using SKYPE4COMLib;

namespace SkypeLogger.Forms
{
    public partial class Main : Form
    {
        private Skype _skype;
        private SkypeChat _current;

        public Main()
        {
            InitializeComponent();
            _skype = new Skype();
            _current = null;

            foreach (Chat c in _skype.RecentChats)
                chatsListView.Items.Add(new ListViewItem(c.FriendlyName) { Tag = new SkypeChat(c) });

            _skype.MessageStatus += new _ISkypeEvents_MessageStatusEventHandler(_skype_MessageStatus);
        }

        private void _skype_MessageStatus(ChatMessage m, TChatMessageStatus t)
        {
            if (t == TChatMessageStatus.cmsReceived || t == TChatMessageStatus.cmsSent)
            {
                lock (messagesListView)
                {
                    foreach (ListViewItem l in chatsListView.Items)
                    {
                        if (((SkypeChat)l.Tag).Name == m.Chat.Name)
                        {
                            SkypeMessage s = new SkypeMessage(m);

                            ((SkypeChat)l.Tag).addMessage(s);

                            if (_current != null && _current.Name == m.ChatName)
                                messagesListView.Items.Add(new ListViewItem(new string[] { s.Sender, s.Body, s.Timestamp.ToString() }) { Tag = s });

                            return;
                        }
                    }

                    ListViewItem lvi = new ListViewItem(m.Chat.FriendlyName) { Tag = new SkypeChat(m.Chat) };
                    chatsListView.Items.Insert(0, lvi);

                    ((SkypeChat)lvi.Tag).addMessage(new SkypeMessage(m));
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) e.Cancel = true;
        }

        private void chatsListView_DoubleClick(object sender, EventArgs e)
        {
            if (chatsListView.SelectedItems.Count != 1) return;

            lock (messagesListView)
            {
                messagesListView.Items.Clear();
                _current = (SkypeChat)chatsListView.SelectedItems[0].Tag;

                foreach (SkypeMessage s in ((SkypeChat)chatsListView.SelectedItems[0].Tag).Messages.Values)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { s.Message.Sender.FullName, s.Body, s.Message.Timestamp.ToString() }) { Tag = s };
                    lvi.BackColor = getBackColor(lvi);
                    messagesListView.Items.Add(lvi);
                }
            }
        }

        private void messagesListView_DoubleClick(object sender, EventArgs e)
        {
            if (messagesListView.SelectedItems.Count != 1) return;

            if (messagesListView.SelectedItems[0].BackColor == Color.CornflowerBlue)
            {
                (new Edited((SkypeMessage)messagesListView.SelectedItems[0].Tag)).ShowDialog();
            }
            else
            {
                (new Unedited((SkypeMessage)messagesListView.SelectedItems[0].Tag)).ShowDialog();
            }
        }

        private void chatMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (messagesListView.SelectedItems.Count == 0)
                e.Cancel = true;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Find f = new Find())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    if (f.SearchType == 0)
                    {
                        foreach (ListViewItem l in messagesListView.Items)
                        {
                            SkypeMessage message = (SkypeMessage)l.Tag;

                            if (message.Sender.ToLower().Contains(f.SearchText))
                                l.BackColor = Color.Gray;
                            else
                                l.BackColor = getBackColor(l);
                        }
                    }
                    else if (f.SearchType == 1)
                    {
                        foreach (ListViewItem l in messagesListView.Items)
                        {
                            SkypeMessage message = (SkypeMessage)l.Tag;

                            if (message.Body.ToLower().Contains(f.SearchText))
                                l.BackColor = Color.Gray;
                            else
                                l.BackColor = getBackColor(l);
                        }
                    }
                    else if (f.SearchType == 2)
                    {
                        foreach (ListViewItem l in messagesListView.Items)
                        {
                            SkypeMessage message = (SkypeMessage)l.Tag;

                            if (message.Timestamp.ToString().ToLower().Contains(f.SearchText))
                                l.BackColor = Color.Gray;
                            else
                                l.BackColor = getBackColor(l);
                        }
                    }
                }
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (messagesListView.SelectedItems.Count == 1)
            {
                SkypeMessage message = (SkypeMessage)messagesListView.SelectedItems[0].Tag;
                Clipboard.SetText(message.Sender);
            }
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (messagesListView.SelectedItems.Count == 1)
            {
                SkypeMessage message = (SkypeMessage)messagesListView.SelectedItems[0].Tag;
                Clipboard.SetText(message.Body);
            }
        }

        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (messagesListView.SelectedItems.Count == 1)
            {
                SkypeMessage message = (SkypeMessage)messagesListView.SelectedItems[0].Tag;
                Clipboard.SetText(message.Timestamp.ToString());
            }
        }

        private Color getBackColor(ListViewItem l)
        {
            if (l.Tag == null)
                return Color.White;

            SkypeMessage s = (SkypeMessage)l.Tag;

            if (s.isRemoved())
                return Color.PaleVioletRed;

            if (s.isEdited())
                return Color.CornflowerBlue;

            return Color.White;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (_current == null) return;

            lock (messagesListView)
            {
                messagesListView.Items.Clear();

                foreach (SkypeMessage s in (_current.Messages.Values))
                {
                    ListViewItem lvi = new ListViewItem(new string[] { s.Message.Sender.FullName, s.Body, s.Message.Timestamp.ToString() }) { Tag = s };
                    lvi.BackColor = getBackColor(lvi);
                    messagesListView.Items.Add(lvi);
                }
            }
        }
    }
}
