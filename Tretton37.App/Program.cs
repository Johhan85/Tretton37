using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Tretton37.Worker;
using Tretton37.Worker.Helper;

namespace Tretton37.App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddMediatR(AppDomain.CurrentDomain.GetAssemblies())
                .AddSingleton<IHttpClientHelper, HttpClientHelper>()
                .AddSingleton<IWorkerService, WorkerService>()
                .BuildServiceProvider();

            var workerService = serviceProvider.GetService<IWorkerService>();

            await workerService.Run("/");
        }
    }
}