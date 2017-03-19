using System;
using System.Windows.Forms;

namespace USM
{
    class AutoUpdateUnturnedTimer : IDisposable
    {
        public Timer Timer;
        public AutoUpdateUnturnedTimer()
        {
            if (!(Variables.UpdateUnturned == 0))
            {
                Timer = new Timer();
                Timer.Interval = Variables.UpdateUnturned;
                Timer.Tick += new EventHandler(Timer_tick);
                Timer.Start();
                Logger.Log("Started timer to update unturned every " + Variables.UpdateUnturned + " days.");
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
            // Shutdown servers, run background worker to update unturned as if updater clicked the update unturned button.
        }
    }
}
