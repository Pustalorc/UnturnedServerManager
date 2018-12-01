using System.IO;
using ATORTTeam.UnturnedServerManager.Configuration;

namespace ATORTTeam.UnturnedServerManager.Constants
{
    internal static class RocketModServerPath
    {
        public static string Value => Path.Combine(Installation.Load().InstallationPath, "My Server");
    }
}