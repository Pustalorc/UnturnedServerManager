using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace UnturnedServerManager
{
    public class Languages
    {
        private Dictionary<string, Dictionary<uint, string>> AvailableTranslations;

        public Languages(string Directory)
        {
            FileInfo[] files = new DirectoryInfo(Path.GetFullPath(Directory)).GetFiles(".exe");
            if (files.Count() > 0)
            {
                foreach (FileInfo File in files)
                {
                    LoadTranslation(File.FullName)
                }
            }
        }

        private void WriteDefaults()
        {
            Dictionary<uint, string> DefaultEnglishTranslations = new Dictionary<uint, string>()
            {
                { 0, "Unturned Server Manager" }
            };
            Dictionary<uint, string> DefaultSpanishTranslations = new Dictionary<uint, string>()
            {
                { 0, "Administrador de Servidor de Unturned" }
            };
            Language English = new Language("English", DefaultEnglishTranslations);
            Language Spanish = new Language("Spanish", DefaultSpanishTranslations);

            XmlSerializer xs = new XmlSerializer(typeof(Language));
            TextWriter tw = new StreamWriter("");
            xs.Serialize(tw, English);
            tw = new StreamWriter("");
            xs.Serialize(tw, Spanish);
        }

        private void LoadTranslation(string File)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Language));
            using (var sr = new StreamReader(Path.GetFullPath(File)))
            {
                var gar = (Language)xs.Deserialize(sr);
                AvailableTranslations.Add(gar.Name, gar.Translations);
            }
        }
    }

    [Serializable]
    public class Language
    {
        public string Name;
        public Dictionary<uint, string> Translations;

        public Language(string LName, Dictionary<uint, string> Trans)
        {
            Name = LName;
            Translations = Trans;
        }
    }
}