using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Numerics;



namespace AdvPing
{
    public class Statics
    {
#if DEBUG
        private const int ClearCount = 10;
#else
        private const int ClearCount = 16384;
#endif
        public BigInteger Max { get; private set; }
        public BigInteger Min { get; private set; }
        public double Average { get; private set; }
        public BigInteger Sent { get; private set; }
        public BigInteger Recved { get; private set; }
        public BigInteger Lost { get; private set; }
        public double PkgLstRate { get; private set; }
        private double LastAverage { get; set; }
        private BigInteger LastCount { get; set; }
        private BigInteger LastRecived { get; set; }
        private double LastPkgLstRate { get; set; }

        public BigInteger TotalSent
        {
            get
            {
                return Sent + LastCount;
            }
        }
        public BigInteger TotalRecved
        {
            get
            {
                return Recved + LastRecived;
            }
        }
        public BigInteger TotalLost
        {
            get
            {
                return TotalSent - TotalRecved;
            }
        }

        public void Add(StatRecord r)
        {
            if (r.Delay == 0 || r.Lost == 1)
                r.Delay = (int)Average;
            Records.Add(r);

            var SumDelay = Records.Sum(x => x.Delay);

            Sent = Records.Count;
            Recved = Records.Sum(x => (x.Lost == 0 ? 1 : 0));
            Lost = Sent - Recved;
            double NewAvg = (double)(SumDelay / (BigRational)Sent);
            double NewLostRate = (double)(Lost / (BigRational)Sent);
            double PctOld = (double)(LastCount / (BigRational)(LastCount + Sent));
            double PctNew = (double)(Sent / (BigRational)(LastCount + Sent));
            Average = LastAverage * PctOld + NewAvg * PctNew;
            PkgLstRate = (LastPkgLstRate * PctOld + NewLostRate * PctNew) * 100;
            Max = Records.Max(x => x.Delay);
            Min = Records.Min(x => x.Delay);

            if (Records.Count >= ClearCount)
            {
                Records.Clear();
                LastCount += ClearCount;
                LastAverage = Average;
                LastRecived += Recved;
            }
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
                    return TotalSent;
                case "rcv":
                case "recved":
                case "received":
                    return TotalRecved;
                case "los":
                case "lost":
                    return TotalLost;
                case "pct":
                case "lostpct":
                    return PkgLstRate;
                default:
                    return 0;
            }
        }
    }
}
