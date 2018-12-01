using System.Linq;
using System.Net;
using System.Xml;

namespace ATORTTeam.UnturnedServerManager.Versions
{
    internal static class RocketBuild
    {
        public static string Value
        {
            get
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                var doc = new XmlDocument();
                var rq = (HttpWebRequest) WebRequest.Create(
                    "https://ci.rocketmod.net/job/Rocket.Unturned/api/xml?xpath=/*/lastStableBuild");

                rq.Timeout = 10000;

                var response = rq.GetResponse() as HttpWebResponse;

                using (var responseStream = response?.GetResponseStream())
                {
                    if (responseStream == null)
                        return "N/A";

                    var reader = new XmlTextReader(responseStream);
                    doc.Load(reader);
                }

                return doc.DocumentElement?.SelectNodes("/lastStableBuild")?.Cast<XmlNode>().ToList()[0]
                           .SelectNodes("number")?.Cast<XmlNode>().ToList()[0].InnerXml ?? "N/A";
            }
        }
    }
}