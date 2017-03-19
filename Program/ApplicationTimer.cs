using System;
using System.Windows.Forms;

namespace USM
{
    class ApplicationTimer : IDisposable
    {
        public Timer Timer;
        public static decimal ProgramTime = 0.00M;
        public ApplicationTimer()
        {
            Timer = new Timer();
            Timer.Interval = 10;
            Timer.Tick += new EventHandler(Timer_tick);
            Timer.Start();
            Logger.Log("Started timer to keep the program time.");
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
            ProgramTime += 0.01M;
        }
    }
}
