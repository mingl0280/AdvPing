using System;
using static AdvPing.EnumTypes;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Numerics;

namespace AdvPing
{
    public class StaticsItem
    {

        private string _text = "";
        private string _name = "";
        private TimeSegmentTypes _timeSegment = TimeSegmentTypes.us;
        private double _timeValue = 0;
        private Label _assignedLabel;
        private string _format = "0.00";
        public override string ToString()
        {
            return Text;
        }

        public StaticsItem()
        {
            Text = "";
            TimeValue = 0;
            TimeSegment = TimeSegmentTypes.us;
            Name = "";
        }

        public StaticsItem(string StaticItemName)
        {
            Text = "";
            TimeValue = 0;
            TimeSegment = TimeSegmentTypes.us;
            Name = StaticItemName;
        }
        /// <summary>
        /// 构造统计标签项
        /// </summary>
        /// <param name="StaticItemName">统计项名称</param>
        /// <param name="label">挂钩的Label</param>
        /// <param name="tsUnit">统计项单位</param>
        /// <param name="showUnit">是否显示单位</param>
        public StaticsItem(string StaticItemName, ref Label label, TimeSegmentTypes tsUnit = TimeSegmentTypes.us)
        {
            Text = "";
            TimeValue = 0;
            TimeSegment = tsUnit;
            Name = StaticItemName;
            AssignedLabel = label;
        }

        public void SetAssoicatedLabel(ref Label label)
        {
            _assignedLabel = label;
        }

        public void SetTimeValue(object n)
        {
            if (n.GetType().Equals(typeof(int)))
            {
                TimeValue = (int)n;
                _format = "0";
            }
            if (n.GetType().Equals(typeof(double)))
            {
                TimeValue = (double)n;
                _format = "0.00";
            }
            if (n.GetType().Equals(typeof(BigInteger)))
            {
                TimeValue = 0;
                _format = "" + ((BigInteger)n).ToString();
            }
        }

        public ref Label AssignedLabel { get { return ref _assignedLabel; } }

        public string Text
        {
            get => _text; private set
            {
                _text = string.IsNullOrEmpty(value) ? "" : value;
                if (AssignedLabel != null)
                {
                    AssignedLabel.Text = _text;
                }
            }
        }
        /// <summary>
        /// 延迟时间
        /// </summary>
        public double TimeValue
        {
            get => _timeValue;
            set
            {
                _timeValue = value;
                Text = Name + ": " + TimeValue.ToString(_format) + (TimeSegment == TimeSegmentTypes.pct ? "%" : (TimeSegment != TimeSegmentTypes.none ? " " + Enum.GetName(typeof(TimeSegmentTypes), TimeSegment) : ""));
            }
        }

        /// <summary>
        /// 时间单位
        /// </summary>
        public TimeSegmentTypes TimeSegment
        {
            get => _timeSegment;
            set
            {
                _timeSegment = value;
                Text = Name + ": " + TimeValue.ToString(_format) + (TimeSegment == TimeSegmentTypes.pct ? "%" : (TimeSegment != TimeSegmentTypes.none ? " " + Enum.GetName(typeof(TimeSegmentTypes), TimeSegment) : ""));
            }
        }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = string.IsNullOrEmpty(value) ? "" : value;
                Text = Name + ": " + TimeValue.ToString(_format) + (TimeSegment == TimeSegmentTypes.pct ? "%" : (TimeSegment != TimeSegmentTypes.none ? " " + Enum.GetName(typeof(TimeSegmentTypes), TimeSegment) : ""));
            }
        }

    }
}
