using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tretton37.Worker.Commands;
using Tretton37.Worker.Helper;

namespace Tretton37.Worker.Handlers
{
    public class DataHandler : IRequestHandler<GetDataQuery, string>
    {
        private IHttpClientHelper _httpHelper;
        public DataHandler(IHttpClientHelper httpHelper)
        {
            _httpHelper = httpHelper;
        }
        public async Task<string> Handle(GetDataQuery request, CancellationToken cancellationToken)
        {
            var response = await _httpHelper.HttpClient.GetAsync(request.Path);
            return "string";
        }
    }
}
