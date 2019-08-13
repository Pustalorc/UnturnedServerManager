using System.IO;
using System.Runtime.InteropServices;
using Pustalorc.Applications.USM.Configuration;

namespace Pustalorc.Applications.USM.Constants
{
    internal static class ServerPath
    {
        public static string Value => RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
            ? Installation.Load().InstallationPath
            : Path.Combine(Installation.Load().InstallationPath, "Server");
    }
}