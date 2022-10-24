using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tretton37.Worker.Commands
{
    public class GetDataQuery : IRequest<string>
    {
        public GetDataQuery(string path)
        {
            Path = path;
        }
        public string? Path { get; }
    }
}
