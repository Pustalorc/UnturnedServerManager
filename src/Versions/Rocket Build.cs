using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Xml;

namespace ATORTTeam.UnturnedServerManager.Versions
{
    public static class RocketBuild
    {
        public static string Value
        {
            get
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
                XmlDocument Doc = new XmlDocument();
                HttpWebRequest rq = (HttpWebRequest)WebRequest.Create("https://ci.rocketmod.net/job/Rocket.Unturned/api/xml?xpath=/*/lastStableBuild");

                rq.Timeout = 10000;

                HttpWebResponse response = rq.GetResponse() as HttpWebResponse;

                using (Stream responseStream = response.GetResponseStream())
                {
                    XmlTextReader reader = new XmlTextReader(responseStream);
                    Doc.Load(reader);
                }

                return Doc.DocumentElement.SelectNodes("/lastStableBuild").Cast<XmlNode>().ToList()[0].SelectNodes("number").Cast<XmlNode>().ToList()[0].InnerXml ?? "N/A";
            }
        }
    }
}
