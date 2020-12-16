using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models.SampleTestModels
{
    public class DataModel
    {
        public string day { get; set; }
        public int? totalSamplesTested { get; set; }
        public int? totalIndividualsTested { get; set; }
        public int? totalPositiveCases { get; set; }
        public string source { get; set; }
    }
}
