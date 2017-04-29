using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer
{
    public class French : ILanguage
    {
        public Dictionary<uint, string> Language
        {
            get
            {
                return new Dictionary<uint, string>
                {
                    { 0, "Langue" },
                    { 1, "Choissis un langue:" },
                    { 2, "Suivant" }
                };
            }
        }

        public string Name
        {
            get
            {
                return "French";
            }
        }
    }
}
