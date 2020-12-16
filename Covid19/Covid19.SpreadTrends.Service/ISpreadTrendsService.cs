using Covid19.Models.SpreadTrendsModels;
using System;
using System.Threading.Tasks;

namespace Covid19.SpreadTrends.Service
{
    public interface ISpreadTrendsService
    {
        Task<SpreadTrendRootSTModel> ConsumeSpreadTrendsApiAsync();
    }
}
