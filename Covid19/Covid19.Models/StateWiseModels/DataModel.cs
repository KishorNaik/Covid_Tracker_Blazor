using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models.StateWiseModels
{
    public class DataModel
    {
        public SummaryModel summary { get; set; }
        public List<RegionalModel> regional { get; set; }
    }
}
