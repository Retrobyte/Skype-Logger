using System;
using System.Collections.Generic;
using System.Text;
using SKYPE4COMLib;

namespace SkypeLogger.Classes
{
    public class SkypeMessage
    {
        private ChatMessage _message;

        public SkypeMessage(ChatMessage m)
        {
            _message = m;
            Body = m.Body.Clone().ToString();
        }

        public bool isRemoved()
        {
            return _message.Type == TChatMessageType.cmeSaid && string.IsNullOrEmpty(_message.Body);
        }

        public bool isEdited()
        {
            return !string.IsNullOrEmpty(_message.EditedBy);
        }

        public ChatMessage Message
        {
            get
            {
                return _message;
            }
        }

        public string Sender
        {
            get
            {
                return _message.Sender.FullName;
            }
        }

        public string Body
        {
            get;
            private set;
        }

        public DateTime Timestamp
        {
            get
            {
                return _message.Timestamp;
            }
        }

        public string ChatName
        {
            get
            {
                return _message.ChatName;
            }
        }

        public string Guid
        {
            get
            {
                return _message.Guid;
            }
        }

        public TChatMessageType Type
        {
            get
            {
                return _message.Type;
            }
        }
    }
}
