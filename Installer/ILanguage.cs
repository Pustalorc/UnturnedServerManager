using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Installer
{
    public interface ILanguage
    {
        Dictionary<uint, string> Language { get; }
        string Name { get; }
    }
}
