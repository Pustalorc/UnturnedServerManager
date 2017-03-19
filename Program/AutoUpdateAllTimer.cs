using System;
using System.Windows.Forms;

namespace USM
{
    class AutoUpdateAllTimer : IDisposable
    {
        public Timer Timer;
        public AutoUpdateAllTimer()
        {
            if (!(Variables.UpdateAll == 0))
            {
                Timer = new Timer();
                Timer.Interval = Variables.UpdateAll;
                Timer.Tick += new EventHandler(Timer_tick);
                Timer.Start();
                Logger.Log("Started timer to update everything every " + Variables.UpdateAll + " days.");
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
            // Shutdown servers, run background worker to update everything as if updater clicked the update all button.
        }
    }
}
