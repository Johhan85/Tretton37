using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tretton37.Worker.Helper
{
    public class HttpClientHelper : IHttpClientHelper
    {
        private HttpClient _httpClient;

        public HttpClientHelper()
        {
            InitializeClient();
        }

        public HttpClient HttpClient
        {
            get
            {
                return _httpClient;
            }
        }
        private void InitializeClient()
        {
            string api = ConfigurationManager.AppSettings["uri"];

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(api);
        }
    }
}
