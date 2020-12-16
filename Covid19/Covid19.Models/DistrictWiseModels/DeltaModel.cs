using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models.DistrictWiseModels
{
    public class DeltaModel
    {
        public int? confirmed { get; set; }
        public int? deceased { get; set; }
        public int? recovered { get; set; }
    }
}
