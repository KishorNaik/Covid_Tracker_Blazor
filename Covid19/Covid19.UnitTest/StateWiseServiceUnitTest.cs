using Covid19.App.Setting;
using Covid19.StatsStateWise.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Covid19.UnitTest
{
    [TestClass]
    public class StateWiseServiceUnitTest
    {
        [TestMethod]
        public async Task StateWiseLatestSummaryTestMethod()
        {
            IStateWiseService stateWiseService =
                new StateWiseService
                    ((leEnumApiCollection)=> new FluentClient(ApiResource.Covid19StateWiseSummaryBaseUrl));

            var data = await stateWiseService.ConsumeStateWiseLatestSummaryDataAsync();

            Assert.IsNotNull(data);
        }
    }
}
