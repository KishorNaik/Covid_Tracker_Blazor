using Covid19.Models.DistrictWiseModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid19.DistrictWise.Service
{
    public interface IDistrictWiseService
    {
        Task<List<DistrictRootObjectModel>> ConsumeDistrictWiseApiAsync();
    }
}
