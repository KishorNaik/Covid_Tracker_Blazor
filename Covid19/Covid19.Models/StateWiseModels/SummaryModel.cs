using System;
using System.Collections.Generic;
using System.Text;

namespace Covid19.Models.StateWiseModels
{
    public class SummaryModel
    {
        public int? total { get; set; }
        public int? confirmedCasesIndian { get; set; }
        public int? confirmedCasesForeign { get; set; }
        public int? discharged { get; set; }
        public int? deaths { get; set; }
        public int? confirmedButLocationUnidentified { get; set; }
    }
}
