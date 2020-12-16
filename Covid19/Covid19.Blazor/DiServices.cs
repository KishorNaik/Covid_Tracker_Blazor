using Covid19.App.Setting;
using Covid19.DistrictWise.Service;
using Covid19.SampleTest.Service;
using Covid19.SpreadTrends.Service;
using Covid19.StatsStateWise.Service;
using Microsoft.Extensions.DependencyInjection;
using Pathoschild.Http.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19.Blazor
{
    public static class DiServices
    {
        public static void AddApiConsumeService(this IServiceCollection services)
        {
            services.AddTransient<IStateWiseService, StateWiseService>();
            services.AddTransient<ISampleTestService, SampleTestService>();
            services.AddTransient<ISpreadTrendsService, SpreadTrendsService>();
            services.AddTransient<IDistrictWiseService, DistrictWiseService>();

            services.AddTransient<Func<HttpClientApiCollection, IClient>>
            (
                (
                    leServiceProvider=>
                        leKey =>
                        {
                            FluentClient fluentClient = null;
                            
                            if (leKey == HttpClientApiCollection.StateWiseStatasApi)
                            {
                                fluentClient = new FluentClient(ApiResource.Covid19StateWiseSummaryBaseUrl);
                            }
                            else if (leKey == HttpClientApiCollection.SampleTestApi)
                            {
                                fluentClient = new FluentClient(ApiResource.Covid19SampleTestBaseUrl);
                            }
                            else if (leKey == HttpClientApiCollection.SpreadTrandsApi)
                            {
                                fluentClient = new FluentClient(ApiResource.Covid19SpreadTrendsBaseUrl);
                            }
                            else if (leKey == HttpClientApiCollection.DistrictWiseApi)
                            {
                                fluentClient = new FluentClient(ApiResource.Covid19DistrictWiseBaseUrl);
                            }

                            return fluentClient;
                        }
                )
            );
        }
    }
}
