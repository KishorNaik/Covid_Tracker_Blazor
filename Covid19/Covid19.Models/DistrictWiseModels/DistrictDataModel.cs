using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models.DistrictWiseModels
{
    public class DistrictDataModel
    {
        public string district { get; set; }
        public int? active { get; set; }
        public int? confirmed { get; set; }
        public int? deceased { get; set; }
        public int? recovered { get; set; }
        public DeltaModel delta { get; set; }
    }
}
