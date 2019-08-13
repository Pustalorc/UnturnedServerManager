using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Pustalorc.Applications.USM.Configuration;
using Pustalorc.Applications.USM.Constants;
using Pustalorc.Applications.USM.File_Control;
using Pustalorc.Applications.USM.Loading;

namespace Pustalorc.Applications.USM.Server_Instance
{
    public sealed class Server
    {
        private Process _instance;
        private TextReader _consoleReader;
        private FileSystemWatcher _fileSystemWatcher;

        internal string Name { get; private set; }
        internal bool IsRunning => _instance != null;

        /// <summary>
        ///     The folder in which all the server data is stored.
        /// </summary>
        internal string Folder => Path.Combine(ServerPath.Value, "Servers", Name);

        internal static Server Create(string name, string clone = null)
        {
            var s = new Server {Name = name};

            FileActions.VerifyPath(s.Folder, true);

            if (!string.IsNullOrEmpty(clone)) FileActions.CopyDirectory(clone, s.Folder);

            return s;
        }

        internal void Start()
        {
            var commandsDat = Path.Combine(Folder, "Server", "Commands.dat");

            if (!FileActions.VerifyFile(commandsDat))
            {
                FileActions.VerifyFilePath(commandsDat, true);

                var c = GameConfiguration.Load(Name);
                File.WriteAllLines(commandsDat, c.ToNelson);
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                _instance = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = Path.Combine(ServerPath.Value, "ServerHelper.sh"),
                        Arguments = $" +secureserver/{Name}",
                        WorkingDirectory = ServerPath.Value,
                        RedirectStandardOutput = true,
                        RedirectStandardInput = false,
                        UseShellExecute = false
                    }
                };

                _instance.Start();

                var consoleOutput = $"{Name}.console";

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                    consoleOutput = consoleOutput.Replace(" ", @"\ ");

                _fileSystemWatcher = new FileSystemWatcher(ServerPath.Value, consoleOutput);
                _consoleReader = new StreamReader(new FileStream(Path.Combine(ServerPath.Value, consoleOutput), FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite));

                _fileSystemWatcher.Changed += ConsoleNewOutput;
                _fileSystemWatcher.EnableRaisingEvents = true;
            }
            else
            {
                var serverExec = Path.Combine(ServerPath.Value, "Unturned.exe");

                if (!FileActions.VerifyFile(serverExec))
                    return;

                _instance = new Process
                {
                    StartInfo = new ProcessStartInfo(serverExec, $" -nographics -batchmode +secureserver/{Name}")
                        {WorkingDirectory = ServerPath.Value}
                };
                _instance.Start();
            }
        }

        private void ConsoleNewOutput(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed) return;

            var newline = _consoleReader.ReadToEnd();
            if (!string.IsNullOrEmpty(newline))
                Console.Write($"[{Name}]: {newline}");
        }

        internal void Restart()
        {
            Shutdown();
            Start();
        }

        internal void Shutdown()
        {
            if (_instance == null) return;

            while (!_instance.HasExited)
            {
                _instance.Kill();
                _instance.WaitForExit();
            }

            _instance = null;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                _fileSystemWatcher.EnableRaisingEvents = false;
                _fileSystemWatcher.Changed -= ConsoleNewOutput;
                _consoleReader = null;
                _fileSystemWatcher = null;
            }

            Console.WriteLine($"[{Name}]: Stopped server.");
        }

        internal void Delete()
        {
            Shutdown();

            while (_instance?.HasExited == false)
            {
            }

            Servers.RegisteredServers.Remove(this);
            GameConfiguration.Delete(Name);
            FileActions.DeleteDirectory(Folder);
        }
    }
}