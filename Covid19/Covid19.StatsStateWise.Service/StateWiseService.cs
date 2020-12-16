using Covid19.App.Setting;
using Covid19.Models.StateWiseModels;
using Pathoschild.Http.Client;
using System;
using System.Threading.Tasks;

namespace Covid19.StatsStateWise.Service
{
    public sealed class StateWiseService : IStateWiseService
    {
        #region Declaration
        private readonly IClient client = null;
        #endregion

        #region Constructor
        public StateWiseService(Func<HttpClientApiCollection, IClient> funcClient)
        {
            this.client = funcClient(HttpClientApiCollection.StateWiseStatasApi);
        }
        #endregion 

        #region Public Method
        async Task<StateRootModel> IStateWiseService.ConsumeStateWiseLatestSummaryDataAsync()
        {
            try
            {
                var response =
                    await
                        client
                        ?.GetAsync(ApiResource.Covid19StateWiseSummaryEndPoint)
                        ?.As<StateRootModel>();

                return response;
            }
            catch
            {
                throw;
            }
        }
        #endregion 
    }
}
