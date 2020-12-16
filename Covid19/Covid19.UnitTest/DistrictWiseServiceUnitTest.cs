using Covid19.App.Setting;
using Covid19.DistrictWise.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.UnitTest
{
    [TestClass]
    public class DistrictWiseServiceUnitTest
    {
        [TestMethod]
        public async Task DistrictWiseApiTestMethod()
        {
            IDistrictWiseService districtWiseService =
                new DistrictWiseService((leHttpClientApiCollection) => new FluentClient(ApiResource.Covid19DistrictWiseBaseUrl));

            var response = await districtWiseService?.ConsumeDistrictWiseApiAsync();

            Assert.IsNotNull(response);
        }
    }
}
