using System;
using System.Windows.Forms;

namespace USM
{
    class AutoUpdateRocketTimer : IDisposable
    {
        public Timer Timer;
        public AutoUpdateRocketTimer()
        {
            if (!(Variables.UpdateRocket == 0))
            {
                Timer = new Timer();
                Timer.Interval = Variables.UpdateRocket;
                Timer.Tick += new EventHandler(Timer_tick);
                Timer.Start();
                Logger.Log("Started timer to update rocket every " + Variables.UpdateRocket + " days.");
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
            // Shutdown servers, run background worker to update rocket as if updater clicked the update rocket button.
        }
    }
}
