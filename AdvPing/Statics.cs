using System.Collections.Generic;
using System.Linq;

namespace AdvPing
{
    public class Statics
    {
        public int Max { get; private set; }
        public int Min { get; private set; }
        public double Average { get; private set; }
        public int Sent { get; private set; }
        public int Recved { get; private set; }
        public int Lost { get; private set; }
        public double PkgLstRate { get; private set; }
        public void Add(StatRecord r)
        {
            if (r.Delay == 0 || r.Lost == 1)
                r.Delay = (int)Average;
            Records.Add(r);
            
            var SumDelay = Records.Sum(x => x.Delay);
            Sent = Records.Count;
            Recved = Records.Sum(x => (x.Lost == 0?1:0));
            Lost = Sent - Recved;
            Average = (double)SumDelay / Sent;
            PkgLstRate = (double)Lost / Sent * 100;
            Max = Records.Max(x => x.Delay);
            Min = Records.Min(x => x.Delay);
        }

        public void Clear()
        {
            Max = Min = Sent = Recved = Lost = 0;
            Average = PkgLstRate = 0;
            Records.Clear();
        }
        private List<StatRecord> Records = new List<StatRecord>();

        public object GetValue(string name)
        {
            switch(name.ToLower())
            {
                case "min":
                    return Min;
                case "max":
                    return Max;
                case "avg":
                case "average":
                    return Average;
                case "sent":
                case "snt":
                    return Sent;
                case "rcv":
                case "recved":
                case "received":
                    return Recved;
                case "los":
                case "lost":
                    return Lost;
                case "pct":
                case "lostpct":
                    return PkgLstRate;
                default:
                    return 0;
            }
        }
    }
}
