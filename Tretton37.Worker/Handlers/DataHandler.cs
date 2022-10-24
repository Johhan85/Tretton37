using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tretton37.Worker.Commands;
using Tretton37.Worker.Helper;
using Tretton37.Worker.Models;

namespace Tretton37.Worker.Handlers
{
    public class DataHandler : IRequestHandler<GetDataQuery, Data>
    {
        private IHttpClientHelper _httpHelper;
        public DataHandler(IHttpClientHelper httpHelper)
        {
            _httpHelper = httpHelper;
        }

        public async Task<Data> Handle(GetDataQuery request, CancellationToken cancellationToken)
        {
            var relativePath = request.Path;

            var response = await _httpHelper.HttpClient.GetAsync(relativePath);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsByteArrayAsync();

            var data = new Data(content, relativePath);

            return data;
        }
    }
}
