using Covid19.App.Setting;
using Covid19.Models.DistrictWiseModels;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.DistrictWise.Service
{
    public class DistrictWiseService : IDistrictWiseService
    {
        private readonly IClient client = null;

        public DistrictWiseService(Func<HttpClientApiCollection,IClient> func)
        {
            client = func(HttpClientApiCollection.DistrictWiseApi);
        }

        async Task<List<DistrictRootObjectModel>> IDistrictWiseService.ConsumeDistrictWiseApiAsync()
        {
            try
            {
                var response =
                     await
                     client
                     ?.GetAsync(ApiResource.Covid19DistrictWiseEndPoint)
                     ?.As<List<DistrictRootObjectModel>>();

                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}
