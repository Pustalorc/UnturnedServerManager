using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Pustalorc.Applications.USM.File_Control;

namespace Pustalorc.Applications.USM.Configuration
{
    class ConfigModification
    {
        [JsonIgnore] private static string _filePath;
        public static String Load(string serverName)
        {
            _filePath = $@"config/Server_{serverName}_commands.json";

            var file = Path.Combine(AppContext.BaseDirectory, _filePath);


            return _filePath;
        }


    }
}
