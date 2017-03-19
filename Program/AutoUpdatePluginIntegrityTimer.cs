using System;
using System.Windows.Forms;

namespace USM
{
    class AutoUpdatePluginIntegrityTimer : IDisposable
    {
        public Timer Timer;
        public AutoUpdatePluginIntegrityTimer()
        {
            if (!(Variables.UpdatePI == 0))
            {
                Timer = new Timer();
                Timer.Interval = Variables.UpdatePI;
                Timer.Tick += new EventHandler(Timer_tick);
                Timer.Start();
                Logger.Log("Started timer to update PI every " + Variables.UpdatePI + " days.");
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }
            Timer.Dispose();
            disposed = true;
        }

        private void Timer_tick(object Sender, EventArgs e)
        {
            // Shutdown servers, run background worker to update PI as if updater clicked the update PI button.
        }
    }
}
