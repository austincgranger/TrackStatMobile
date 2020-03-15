using System;
using System.Collections.Generic;
using System.Text;

namespace TrackStatMobile.Models
{
    public class Stats
    {
        public string StatisticId { get; set; }
        public string IndependetVariable { get; set; }
        public string DependentVariable { get; set; }
        public string[] StatisticValue { get; set; }
    }
}
