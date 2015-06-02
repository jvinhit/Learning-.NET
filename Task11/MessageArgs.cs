using System;

namespace Task11
{
    class MessageArgs : EventArgs
    {
        public string DisplayMessage
        {
            get;
            private set;
        }

        public byte[] DataInBytes
        {
            get;
            private set;
        }

        public MessageArgs(string message, byte[] bytes)
        {
            DisplayMessage = message;
            DataInBytes = bytes;
        }
    }
}
