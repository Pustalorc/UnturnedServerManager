using System.Diagnostics;
using System.IO;
using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.File_Control;
using ATORTTeam.UnturnedServerManager.Memory;

namespace ATORTTeam.UnturnedServerManager.Server_Instance
{
    public sealed class Server
    {
        private Process _instance;
        internal string Name { get; private set; }
        internal bool IsRunning => _instance != null;

        /// <summary>
        ///     The folder in which all the server data is stored.
        /// </summary>
        internal string Folder =>
            Path.Combine(RocketModServerPath.Value, "Servers", Name);

        internal static Server Create(string name, string clone = null)
        {
            var s = new Server {Name = name};

            if (string.IsNullOrEmpty(clone))
                FileActions.VerifyPath(s.Folder, true);
            else
                FileActions.CopyDirectory(clone, s.Folder);

            return s;
        }

        internal void Start()
        {
            var commandsDat = Path.Combine(Folder, "Server", "Commands.dat");
            if (!FileActions.VerifyFile(commandsDat))
            {
                FileActions.VerifyFilePath(commandsDat, true);

                var c = CommandsDotDat.Load(Name);
                File.WriteAllLines(commandsDat, c.ToNelson);
            }

            const string arguments = " -batchmode -nographics +secureserver";
            var serverExec =
                Path.Combine(RocketModServerPath.Value, "Unturned.exe");
            if (!FileActions.VerifyFile(serverExec))
                return;

            _instance = new Process
            {
                StartInfo = new ProcessStartInfo(serverExec, $"{arguments}/{Name}")
                {
                    WorkingDirectory = RocketModServerPath.Value
                }
            };
            _instance.Start();
        }

        internal void Restart()
        {
            Shutdown();
            Start();
        }

        internal void Shutdown()
        {
            // Look into getting a control on the console window and writing text directly to it.
            if (_instance == null)
                return;

            if (!_instance.HasExited)
                _instance.Kill();

            _instance = null;
            // In the meantime use this.
        }

        internal void Delete()
        {
            Shutdown();

            while (_instance?.HasExited == false)
            {
            }

            Servers.Value.Remove(this);
            CommandsDotDat.Delete(Name);
            FileActions.DeleteDirectory(Folder);
        }
    }
}