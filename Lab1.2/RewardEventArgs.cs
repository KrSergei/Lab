using System;

namespace Lab1._2
{
    class RewardEventArgs : EventArgs
    {
        public RewardEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
