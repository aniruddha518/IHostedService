using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace BackgroundTaskDemo
{
    public class BrackgroundPrinter:IHostedService //, IDisposable
    {
        private readonly ILogger<BrackgroundPrinter> logger;
        //private int number = 0;
        //private Timer timer;

        private readonly IWorker worker;

        public BrackgroundPrinter(ILogger<BrackgroundPrinter> logger, IWorker worker)
        {
            this.logger=logger;
            this.worker=worker;
        }

        //public void Dispose()
        //{
        //    timer?.Dispose();
        //}

        //public Task StartAsync(CancellationToken cancellationToken)
        //{
        //    timer = new Timer(o =>
        //    {
        //        Interlocked.Increment(ref number);
        //        logger.LogInformation($"Printing from worker number: {number}");
        //    },
        //        null, TimeSpan.Zero,
        //        TimeSpan.FromSeconds(5));

        //    return Task.CompletedTask;
        //}
        public async Task StartAsync(CancellationToken cancellationToken)
        {
             await worker.Dowork(cancellationToken);
        }
        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("Printing worker Stopping");
            return Task.CompletedTask;
        }
    }
}
