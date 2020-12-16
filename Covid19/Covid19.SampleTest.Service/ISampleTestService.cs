using Covid19.Models.SampleTestModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.SampleTest.Service
{
    public interface ISampleTestService
    {
        Task<SampleTestRootModel> ConsumeSampleTestApiAsync();
    }
}
