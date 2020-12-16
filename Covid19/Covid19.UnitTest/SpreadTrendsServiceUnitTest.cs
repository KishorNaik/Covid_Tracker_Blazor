using Covid19.App.Setting;
using Covid19.SpreadTrends.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.UnitTest
{
    [TestClass]
    public class SpreadTrendsServiceUnitTest
    {
        [TestMethod]
        public async Task SpreadTrendsServiceTestMethod()
        {
            ISpreadTrendsService spreadTrends =
                new SpreadTrendsService
                    ((leEnumApiCollection) => new FluentClient(ApiResource.Covid19SpreadTrendsBaseUrl));

            var data = await spreadTrends.ConsumeSpreadTrendsApiAsync();

            Assert.IsNotNull(data);
        }
    }
}
