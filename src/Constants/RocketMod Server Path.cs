using ATORTTeam.UnturnedServerManager.Configuration;
using System.IO;

namespace ATORTTeam.UnturnedServerManager.Constants
{
    public static class RocketmodServerPath
    {
        public static string Value => Path.Combine(Installation.Load().InstallationPath, "Rocketmod Server");
    }
}
