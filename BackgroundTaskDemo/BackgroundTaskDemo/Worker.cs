using System.Runtime.InteropServices;

namespace BackgroundTaskDemo
{
    public class Worker : IWorker
    {
        private readonly ILogger<Worker> logger;
        private int number = 0;
        public Worker(ILogger<Worker> logger)
        {
            this.logger = logger;
        }

        public async Task Dowork(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                Interlocked.Increment(ref number);

                using (var client=new HttpClient())
                {
                    try
                    {
                        client.BaseAddress = new Uri("https://localhost:7214/");
                        using (HttpResponseMessage response = await client.GetAsync("GetCunnectionChecker"))
                        {
                            var responseContent = response.Content.ReadAsStringAsync().Result;
                            response.EnsureSuccessStatusCode();

                            logger.LogInformation($"Result IS {responseContent} and Printing from worker number: {number}");
                        }
                    }
                    catch(Exception ex)
                    {
                        logger.LogInformation($"Result IS NO and Printing from worker number: {number}");
                    }
                }


                    
                await Task.Delay(1000 * 5);
            }
        }
    }
}
