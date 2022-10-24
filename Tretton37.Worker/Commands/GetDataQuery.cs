using MediatR;
using Tretton37.Worker.Models;

namespace Tretton37.Worker.Commands
{
    public class GetDataQuery : IRequest<Data>
    {
        public GetDataQuery(string path)
        {
            Path = path;
        }
        public string? Path { get; }
    }
}
