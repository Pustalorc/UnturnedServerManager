using ATORTTeam.UnturnedServerManager.FileControl;
using Rocket.API.Serialisation;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ATORTTeam.UnturnedServerManager.Memory
{
    public static class Permissions
    {
        private static string Dir = "";
        public static RocketPermissions Perms { get; set; }

        public static void Load(string Path)
        {
            Dir = Path;
            if (FileActions.VerifyFile(Path))
                using (StreamReader reader = new StreamReader(Path))
                {
                    var Serialiser = new XmlSerializer(typeof(RocketPermissions));
                    Perms = Serialiser.Deserialize(reader) as RocketPermissions;
                }
            else
            {
                Perms = new RocketPermissions()
                {
                    DefaultGroup = "default",
                    Groups = new List<RocketPermissionsGroup>()
                    {
                        new RocketPermissionsGroup("default", "default", "", new List<string>(), new List<Permission>(), "white", 100) { Prefix = "", Suffix = "" }
                    }
                };
            }
        }
        public static void Unload()
        {
            if (!string.IsNullOrEmpty(Dir) && Perms != null)
            {
                FileActions.VerifyFilePath(Dir);
                using (StreamWriter reader = new StreamWriter(Dir))
                {
                    var Serialiser = new XmlSerializer(typeof(RocketPermissions));
                    Serialiser.Serialize(reader, Perms);
                }
            }

            Perms = null;
            Dir = null;
        }
    }
}
