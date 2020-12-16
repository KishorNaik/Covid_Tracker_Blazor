using Covid19.App.Setting;
using Covid19.Models.SampleTestModels;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.SampleTest.Service
{
    public class SampleTestService : ISampleTestService
    {
        #region Declaration
        private readonly IClient client = null;
        #endregion

        #region Constructor
        public SampleTestService(Func<HttpClientApiCollection, IClient> funcClient)
        {
            this.client = funcClient(HttpClientApiCollection.SampleTestApi);
        }
        #endregion 

        async Task<SampleTestRootModel> ISampleTestService.ConsumeSampleTestApiAsync()
        {
            try
            {
                var response =
                    await
                        client
                        ?.GetAsync(ApiResource.Covid19SampleTestEndPoint)
                        ?.As<SampleTestRootModel>();

                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}
