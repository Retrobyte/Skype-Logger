using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using SKYPE4COMLib;

namespace SkypeLogger.Classes
{
    public class SkypeChat
    {
        private Chat _chat;
        private Dictionary<string, SkypeMessage> _messages;

        public SkypeChat(Chat c)
        {
            _chat = c;
            _messages = new Dictionary<string, SkypeMessage>();
        }

        public void addMessage(SkypeMessage s)
        {
            if (s.ChatName == _chat.Name && !_messages.ContainsKey(s.Guid))
                _messages.Add(s.Guid, s);
        }

        public string Name
        {
            get
            {
                return _chat.Name;
            }
        }

        public Dictionary<string, SkypeMessage> Messages
        {
            get
            {
                return _messages;
            }
        }
    }
}
