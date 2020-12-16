using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models.DistrictWiseModels
{
    public class DistrictRootObjectModel
    {
        public string state { get; set; }
        public List<DistrictDataModel> districtData { get; set; }
    }
}
