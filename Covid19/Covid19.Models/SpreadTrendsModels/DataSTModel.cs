using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models.SpreadTrendsModels
{
    public class DataSTModel
    {
        public string day { get; set; }
        public SummarySTModel summary { get; set; }
        public List<RegionalSTModel> regional { get; set; }
    }
}
