using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer
{
    public class Spanish : ILanguage
    {

        public Dictionary<uint, string> Language
        {
            get
            {
                return new Dictionary<uint, string>
                {
                    { 0, "Idioma" },
                    { 1, "Elije un idioma:" },
                    { 2, "Siguiente" }
                };
            }
        }

        public string Name
        {
            get
            {
                return "Spanish";
            }
        }
    }
}
