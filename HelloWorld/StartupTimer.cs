using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class StartupTimer : IHostedService, IDisposable
    {
        #region Properties

        private Startup _scoped;
        private Timer _timer;

        #endregion

        #region Constructor

        public StartupTimer(Startup startup)
        {
            _scoped = startup;
        }

        #endregion

        #region Contract Methods

        public void Dispose()
        {
            _timer?.Dispose();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            try
            {
                _timer = new Timer(
                    async e => await Run(),
                    null,
                    TimeSpan.Zero,
                    TimeSpan.FromSeconds(5));
            }
            catch (Exception e)
            {
                throw e;
            }

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            try
            {
                _timer?.Change(Timeout.Infinite, 0);
            }
            catch (Exception e)
            {
                throw e;
            }

            return Task.CompletedTask;
        }
        #endregion

        #region Private Methods

        private async Task Run()
        {
            try
            {
                await _scoped.Run();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
    }
}
