using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer
{
    public class English : ILanguage
    {
        public Dictionary<uint, string> Language
        {
            get
            {
                return new Dictionary<uint, string>
                {
                    { 0, "Language" },
                    { 1, "Chose a language:" },
                    { 2, "Next" }
                };
            }
        }

        public string Name
        {
            get
            {
                return "English";
            }
        }
    }
}
