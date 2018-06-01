using System.Net;

namespace ATORTTeam.UnturnedServerManager.Versions
{
    public static class UnturnedBuild
    {
        public static string Value => new WebClient().DownloadString("http://update.unturned.hosting").Trim();
    }
}
