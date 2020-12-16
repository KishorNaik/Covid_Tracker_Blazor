using Covid19.App.Setting;
using Covid19.SampleTest.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.UnitTest
{
    [TestClass]
    public class SampleTestServiceUnitTest
    {
        [TestMethod]
        public async Task SampleTestApiTestMethod()
        {
            ISampleTestService sampleTestService =
                new SampleTestService
                    ((leEnumApiCollection) => new FluentClient(ApiResource.Covid19SampleTestBaseUrl));

            var data = await sampleTestService.ConsumeSampleTestApiAsync();

            Assert.IsNotNull(data);
        }
    }
}
