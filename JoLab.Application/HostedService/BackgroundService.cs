using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace JoLab.Application.HostedService
{
    public class BackgroundService(ILogger<BackgroundService> logger) : IHostedService, IDisposable
    {
        private Timer _timer;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            // Run every 5 minitues
            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromMinutes(2));
            return Task.CompletedTask;
        }

        private async void DoWork(object state)
        {
            await Task.FromResult(true);
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation("MyBackgroundService is stopping.");

            _timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _timer?.Dispose();
        }
    }
}
