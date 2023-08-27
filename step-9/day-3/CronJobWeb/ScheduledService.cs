using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace CronJobWeb
{
    public class ScheduledService : BackgroundService
    {
        public ScheduledService()
        {

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            string filePath = "logs/app-log.txt";

            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine("Scheduled service starting...");
            }

            while (!stoppingToken.IsCancellationRequested)
            {
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine($"Executed scheduled task at: {DateTime.Now}");
                }

                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }
    }
}
