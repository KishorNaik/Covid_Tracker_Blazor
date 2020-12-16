using Covid19.App.Setting;
using Covid19.Models.SpreadTrendsModels;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Covid19.SpreadTrends.Service
{
    public class SpreadTrendsService : ISpreadTrendsService
    {
        #region Declaration
        private readonly IClient client = null;
        #endregion

        #region Constructor
        public SpreadTrendsService(Func<HttpClientApiCollection, IClient> funcClient)
        {
            this.client = funcClient(HttpClientApiCollection.SpreadTrandsApi);
        }
        #endregion 

        async Task<SpreadTrendRootSTModel> ISpreadTrendsService.ConsumeSpreadTrendsApiAsync()
        {
            try
            {
                var response =
                    await
                        client
                        ?.GetAsync(ApiResource.Covid19SpreadTrendsEndPoint)
                        ?.As<SpreadTrendRootSTModel>();

                return response;
            }
            catch
            {
                throw;
            }
        }
    }
}
