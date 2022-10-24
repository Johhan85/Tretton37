using MediatR;
using Tretton37.Worker.Commands;
using Tretton37.Worker.Models;

namespace Tretton37.Worker
{
    public class WorkerService : IWorkerService
    {
        private readonly IMediator _mediator;
        private Dictionary<string, string> _paths = new Dictionary<string, string>(); 
        public WorkerService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Run(string indexPage)
        {
            await TraverseLinks(new[] { indexPage });
        }

        private async Task TraverseLinks(IEnumerable<string> paths)
        {
            List<Data> dataList = new List<Data>();
            List<string> newLinks = new List<string>();

            //Get data with httpClient
            foreach (var path in paths)
            {
                dataList.Add(await _mediator.Send(new GetDataQuery(path)));
                _paths.TryAdd(path, "done");
            }

            //Search for new links
            //Save to disc
            foreach (var data in dataList)
            {
                
            }

            //Compare dictionary and newLinks if they diff
            //TravrseLinks()
        }
    }
}
