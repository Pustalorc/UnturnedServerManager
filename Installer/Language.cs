using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Installer
{
    static public class Language
    {
        public static Dictionary<string, Dictionary<uint, string>> Languages = new Dictionary<string, Dictionary<uint, string>>(int.MaxValue);

        public static string Translate(uint TranslationID, string LanguageName)
        {
            string ret = null;
            if (Languages.ContainsKey(LanguageName))
            {
                Dictionary<uint, string> Translations = Languages[LanguageName];
                if (Translations.ContainsKey(TranslationID))
                {
                    ret = Translations[TranslationID];
                    return ret;
                }
                return ret;
            }
            return ret;
        }

        public static void LoadLanguages()
        {
            var instances = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(ILanguage))
                                     && t.GetConstructor(Type.EmptyTypes) != null
                            select Activator.CreateInstance(t) as ILanguage;

            foreach (var instance in instances)
            {
                Languages.Add(instance.Name, instance.Language);
            }
        }
    }
}
