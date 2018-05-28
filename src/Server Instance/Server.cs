using ATORTTeam.UnturnedServerManager.Configuration;
using ATORTTeam.UnturnedServerManager.Constants;
using ATORTTeam.UnturnedServerManager.FileControl;
using ATORTTeam.UnturnedServerManager.Memory;
using System.Diagnostics;
using System.IO;

namespace ATORTTeam.UnturnedServerManager.ServerInstance
{
    public class Server
    {
        private Process Instance;
        public string Name { get; private set; }
        public ServerType Type { get; private set; }
        public bool IsRunning => Instance != null;
        public string Folder => Path.Combine(Type == ServerType.Vanilla ? VanillaServerPath.Value : RocketmodServerPath.Value, "Servers", Name);

        public static Server Create(string name, ServerType type, string clone = null)
        {
            var s = new Server();
            s.Name = name;
            s.Type = type;

            if (string.IsNullOrEmpty(clone))
                FileActions.VerifyPath(s.Folder);
            else
                FileActions.CopyDirectory(clone, s.Folder);

            return s;
        }

        public void Start()
        {
            var commandsdat = Path.Combine(Folder, "Server", "Commands.dat");
            if (!FileActions.VerifyFile(commandsdat))
            {
                FileActions.VerifyFilePath(commandsdat);

                var c = CommandsDotDat.Load(Name);
                File.WriteAllLines(commandsdat, c.ToNelson);
            }

            string Arguments = " -batchmode -nographics +secureserver";
            string ServerExec = Path.Combine(Type == ServerType.Vanilla ? VanillaServerPath.Value : RocketmodServerPath.Value, "Unturned.exe");
            if (!FileActions.VerifyFile(ServerExec))
                return;

            Instance = new Process();
            Instance.StartInfo = new ProcessStartInfo(ServerExec, Arguments + "/" + Name);
            Instance.StartInfo.WorkingDirectory = Type == ServerType.Vanilla ? VanillaServerPath.Value : RocketmodServerPath.Value;
            Instance.Start();
        }
        public void Restart()
        {
            Shutdown();
            Start();
        }
        public void Shutdown()
        {
            // Look into getting a control on the console window and writing text directly to it.
            if (Instance == null)
                return;

            if (!Instance.HasExited)
                Instance.Kill();

            Instance = null;
            // In the meantime use this.
        }
        public void Delete()
        {
            Shutdown();

            while (Instance != null && !Instance.HasExited) { }

            Servers.Value.Remove(this);
            CommandsDotDat.Delete(Name);
            FileActions.DeleteDirectory(Folder);
        }
    }
}
