using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Diagnostics;

namespace AdvPing
{
    public partial class Form1 : Form
    {
        Dictionary<string, StaticsItem> staticsItems = new Dictionary<string, StaticsItem>();
        PingOptions pOpt = new PingOptions();
        PingImpl ping;
        Statics stat;
        Stopwatch sw = new Stopwatch();
        string HostName = "";
        IPAddress WaitPingIP;
        int LineCount = 0;

        private delegate void PEventRecived(PingCompeleteEventArgs e);
        private delegate void NoParamDeleg();


        public Form1()
        {
            InitializeComponent();
            staticsItems.Add("min", new StaticsItem("最短", ref labelMin));
            staticsItems.Add("max", new StaticsItem("最长", ref labelMax));
            staticsItems.Add("avg", new StaticsItem("平均", ref labelAvg));
            staticsItems.Add("snt", new StaticsItem("已发送", ref labelSent, EnumTypes.TimeSegmentTypes.none));
            staticsItems.Add("rcv", new StaticsItem("已接收", ref labelRecved, EnumTypes.TimeSegmentTypes.none));
            staticsItems.Add("los", new StaticsItem("已丢失", ref labelLost, EnumTypes.TimeSegmentTypes.none));
            staticsItems.Add("pct", new StaticsItem("丢包率", ref labelPctLost, EnumTypes.TimeSegmentTypes.pct));
            staticsItems.Add("dur", new StaticsItem("时长", ref labelContTime, EnumTypes.TimeSegmentTypes.s));
        }


        private void checkBoxNSeg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNSeg.Checked)
                pOpt.DontFragment = true;
            else
                pOpt.DontFragment = false;
        }

        private void buttonBegin_Click(object sender, EventArgs e)
        {
            
            bool isIP = IPAddress.TryParse(textBoxIP.Text, out WaitPingIP);

            if (!isIP)
            {
                HostName = textBoxIP.Text;
                IPAddress[] WaitSelectList;
                try
                {
                    WaitSelectList = Dns.GetHostAddresses(HostName);
                }
                catch (Exception)
                {
                    MessageBox.Show("错误", "解析域名失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                for (int i = 0; i < WaitSelectList.Length; i++)
                {
                    var ipItem = WaitSelectList[i];
                    if (ipItem.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6 && checkBoxIPV6.Checked)
                    {
                        WaitPingIP = ipItem;
                        break;
                    }
                    if (ipItem.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && checkBoxIPV4.Checked)
                    {
                        WaitPingIP = ipItem;
                        break;
                    }
                    if (i == WaitSelectList.Length - 1)
                    {
                        WaitPingIP = ipItem;
                    }
                }
            }
            if (WaitPingIP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6 && !(checkBoxIPV6.Checked))
            {
                MessageBox.Show("错误", "禁用了IPV6或未解析到IPV6地址", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (WaitPingIP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && !(checkBoxIPV4.Checked))
            {
                MessageBox.Show("错误", "禁用了IPV4或未解析到IPV4地址", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sw.Reset();
            sw.Start();

            PingOptions opt = new PingOptions(decimal.ToInt32(numericUpDownTTL.Value), checkBoxNSeg.Checked);
            ping = new PingImpl(WaitPingIP, HostName, decimal.ToInt32(numericUpDownCnt.Value), decimal.ToInt32(numericUpDownLen.Value), decimal.ToInt32(numericUpDownTimeout.Value) * 1000, opt);
            ping.ReplyEventReceived += Ping_ReplyEventReceived;
            ping.PingEnded += Ping_PingEnded;

            textBoxLog.Clear();
            LineCount = 0;
            textBoxLog.AppendText(string.Format("正在Ping {0} 使用 {1} 字节的数据:\r\n", (HostName == "" ? WaitPingIP.ToString() : string.Format("{0} [{1}]", HostName, WaitPingIP.ToString())), decimal.ToInt32(numericUpDownLen.Value)));
            LineCount++;
            if (stat == null)
                stat = new Statics();
            else
                stat.Clear();
            DisableAll();
        }

        private void Ping_PingEnded(object sender, EventArgs e)
        {
            BeginInvoke(new NoParamDeleg(EnableAll));
            ping = null;
        }

        private void DisableAll()
        {
            buttonBegin.Enabled = false;
            textBoxIP.Enabled = false;
            numericUpDownCnt.Enabled = false;
            numericUpDownLen.Enabled = false;
            numericUpDownTimeout.Enabled = false;
            numericUpDownTTL.Enabled = false;
            checkBoxIPV4.Enabled = false;
            checkBoxIPV6.Enabled = false;
            checkBoxNSeg.Enabled = false;
            buttonEnd.Enabled = true;
        }
        private void EnableAll()
        {
            sw.Stop();
            staticsItems["dur"].SetTimeValue(sw.Elapsed.Seconds);
            buttonBegin.Enabled = true;
            textBoxIP.Enabled = true;
            numericUpDownCnt.Enabled = true;
            numericUpDownLen.Enabled = true;
            numericUpDownTimeout.Enabled = true;
            numericUpDownTTL.Enabled = true;
            checkBoxIPV4.Enabled = true;
            checkBoxIPV6.Enabled = true;
            checkBoxNSeg.Enabled = true;
            buttonEnd.Enabled = false;
        }

        private void OnReplyRecived(PingCompeleteEventArgs e)
        {
            if (LineCount > 10000)
            {
                textBoxLog.Clear();
                LineCount = 0;
            }
            if (e.Reply.GetType().Equals(typeof(string)))
            {
                textBoxLog.AppendText((string)e.Reply);
                stat.Add(new StatRecord() { Delay = 0, Lost = 1 });
            }
            else
            {
                switch (((PingReply)e.Reply).Status)
                {
                    case IPStatus.Success:
                        if (textBoxLog.Text == "")
                            textBoxLog.AppendText(string.Format("正在Ping {0} 使用 {1} 字节的数据:\r\n", (HostName == "" ? WaitPingIP.ToString() : string.Format("{0} [{1}]", HostName, WaitPingIP.ToString())), decimal.ToInt32(numericUpDownLen.Value)));
                        textBoxLog.AppendText(string.Format(
                            "来自{0}的回复:字节={1} 时间={2}us {3}", 
                            ((PingReply)e.Reply).Address.ToString(),
                            ((PingReply)e.Reply).Buffer.Length,
                            e.CurrentPacketTime / 2,
                            ((PingReply)e.Reply).Options != null ?
                                    "TTL=" + ((PingReply)e.Reply).Options.Ttl.ToString() :
                                    ""));
                        break;
                    case IPStatus.TtlExpired:
                    case IPStatus.TimeExceeded:
                        textBoxLog.AppendText(string.Format("来自{0}的回复: TTL过期", ((PingReply)e.Reply).Address.ToString()));
                        break;
                    case IPStatus.TimedOut:
                        textBoxLog.AppendText("请求超时");
                        break;
                    case IPStatus.DestinationUnreachable:
                        textBoxLog.AppendText(string.Format("{0}目标主机无法访问", (((PingReply)e.Reply).Address == null ? "" : string.Format("来自{0}：", ((PingReply)e.Reply).Address.ToString()))));
                        break;
                    case IPStatus.DestinationNetworkUnreachable:
                        textBoxLog.AppendText("目标网络不可抵达");
                        break;
                    default:
                        textBoxLog.AppendText("Ping传输失败:" + Enum.GetName(typeof(IPStatus), ((PingReply)e.Reply).Status));
                        break;
                }
                stat.Add(new StatRecord() { Delay = (((PingReply)e.Reply).Status == IPStatus.Success ? e.CurrentPacketTime / 2 : 0), Lost = (((PingReply)e.Reply).Status == IPStatus.Success ? 0 : 1) });
            }
            textBoxLog.AppendText("\r\n");
            LineCount++;
            foreach (var item in staticsItems)
            {
                if (item.Key == "dur")
                    staticsItems["dur"].SetTimeValue((int)sw.Elapsed.TotalSeconds);
                else
                {
                    var obj = item.Value;
                    obj.SetTimeValue(stat.GetValue(item.Key));
                }
            }
        }

        private void Ping_ReplyEventReceived(object sender, PingCompeleteEventArgs e)
        {
            BeginInvoke(new PEventRecived(OnReplyRecived), e);
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            ping.StopPing();
        }

        private void textBoxIP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonBegin.PerformClick();
                buttonEnd.Focus();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ping != null)
                ping.StopPing();
        }
    }
}
