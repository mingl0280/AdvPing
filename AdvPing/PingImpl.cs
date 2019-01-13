using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Net;
using System.Diagnostics;

namespace AdvPing
{
    public class PingImpl
    {
        public delegate void OnReplyReceivedHandler(object sender, PingCompeleteEventArgs e);
        public delegate void OnPingEndedHandler(object sender, EventArgs e);
        public event OnReplyReceivedHandler ReplyEventReceived;
        public event OnPingEndedHandler PingEnded;

        private void RaiseReplyEventReceivedEvent(int cpid, int cpd, object status)
        {
            PingCompeleteEventArgs e = new PingCompeleteEventArgs(cpid, cpd, status);
            ReplyEventReceived(this, e);
        }
        private void RaiseOnPingEnded()
        {
            EventArgs args = new EventArgs();
            PingEnded(this, args);
        }

        public IPAddress IPAddr { get; private set; }
        public string DomainName { get; private set; }
        public int Count { get; private set; }
        public int PacketLength { get; private set; }
        public PingOptions Option { get; private set; }
        public int Timeout { get; private set; }

        private bool isRunning = false;
        private Thread WorkerThread;
        private int CurrentPacketCount = 0;

        public PingImpl(IPAddress IP, string domain = "", int count = 5, int len = 32,int tout = 5000, PingOptions pOptions = null)
        {
            if (pOptions == null)
            {
                beginPing(IP, domain, count, len , tout, new PingOptions());
            }
            else
            {
                beginPing(IP, domain, count, len,  tout, pOptions);
            }
        }

        private void beginPing(IPAddress IP, string domain, int count, int len,int tout, PingOptions pOptions)
        {
            IPAddr = IP;
            DomainName = domain;
            Count = count;
            PacketLength = len;
            Option = pOptions;
            isRunning = true;
            Timeout = tout;
            WorkerThread = new Thread(WorkerFunc);
            WorkerThread.Start();
        }

        public void StopPing()
        {
            isRunning = false;
            WorkerThread.Abort();
            WorkerThread = null;
        }

        private void WorkerFunc()
        {
            byte[] dataBuf = Enumerable.Repeat((byte)65, PacketLength).ToArray();
            Ping Sender = new Ping();
            Stopwatch stopwatch = new Stopwatch();
            while(isRunning)
            {
                
                PingReply reply;
                try
                {
                    stopwatch.Start();
                    reply = Sender.Send(IPAddr, Timeout, dataBuf, Option);
                    RaiseReplyEventReceivedEvent(CurrentPacketCount, Convert.ToInt32(stopwatch.Elapsed.TotalMilliseconds * 1000), reply);
                }
                catch(Exception ex)
                {
                    RaiseReplyEventReceivedEvent(CurrentPacketCount, Convert.ToInt32(stopwatch.Elapsed.TotalMilliseconds * 1000), ex.Message);
                }
                CurrentPacketCount++;
                if (Count != 0 && CurrentPacketCount >= Count)
                {
                    isRunning = false;
                    RaiseOnPingEnded();
                    return;
                }
                stopwatch.Reset();
                Thread.Sleep(1000);
            }
        }
    }
}
