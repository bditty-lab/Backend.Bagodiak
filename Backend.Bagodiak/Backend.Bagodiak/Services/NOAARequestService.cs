using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Backend.Bagodiak.Services
{
    public class NOAARequestService : IRequestService
    {
        public HttpClient Client { get; set; }
        private string _token;
        public NOAARequestService(string token)
        {
            _token = token ?? throw new ArgumentNullException(nameof(token));  
            Client = new HttpClient {
                BaseAddress = new Uri("https://www.ncdc.noaa.gov/cdo-web/api/v2")
            };
            Client.DefaultRequestHeaders.Authorization
                = new AuthenticationHeaderValue("token", _token);
        }

        public async Task GetDatasets()
        {
            await Client.GetAsync("datasets");
        }

        
        
    }
}