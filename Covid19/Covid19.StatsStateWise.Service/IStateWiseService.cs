using Covid19.Models.StateWiseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.StatsStateWise.Service
{
    public interface IStateWiseService
    {
        Task<StateRootModel> ConsumeStateWiseLatestSummaryDataAsync();
    }
}
