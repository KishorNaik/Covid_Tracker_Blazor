using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models.SampleTestModels
{
    public class SampleTestRootModel
    {
        public bool? success { get; set; }
        public DataModel data { get; set; }
        public DateTime? lastRefreshed { get; set; }
        public DateTime? lastOriginUpdate { get; set; }
    }
}
