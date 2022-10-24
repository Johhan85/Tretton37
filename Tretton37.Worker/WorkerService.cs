using MediatR;
using Tretton37.Worker.Commands;

namespace Tretton37.Worker
{
    public class WorkerService : IWorkerService
    {
        private readonly IMediator _mediator;
        public WorkerService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Run(string indexPage)
        {
            var t = await _mediator.Send(new GetDataQuery(indexPage));
        }
    }
}
