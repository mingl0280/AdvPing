using System;

namespace AdvPing
{
    public class PingCompeleteEventArgs : EventArgs
    {
        public int CurrentPacketID { get; set; }
        public int CurrentPacketTime { get; set; }
        public object Reply { get; set; }

        public PingCompeleteEventArgs(int cpid, int cpd, object status)
        {
            CurrentPacketID = cpid;
            CurrentPacketTime = cpd;
            Reply = status;
        }
    }
}
