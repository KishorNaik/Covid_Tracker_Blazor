using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models.SpreadTrendsModels
{
    public class SpreadTrendRootSTModel
    {
        public bool? success { get; set; }
        public List<DataSTModel> data { get; set; }
        public DateTime? lastRefreshed { get; set; }
        public DateTime? lastOriginUpdate { get; set; }
    }
}
