using System;
using System.Collections.Generic;
using System.Text;

namespace TrackStatMobile.Models
{
    public class Stats
    {
        public string StatisticId { get; set; }
        public string Image { get; set; } = "null";
        public string StatisticName { get; set; }
        public string StatisticMonth { get; set; }
        public double ExpectedValue { get; set; }
        public double ActualValue { get; set; }
    }
}
