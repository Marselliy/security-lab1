using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace security_lab1_csharp
{
    class Logger
    {
        private static string filename;
        public static void init(string filename)
        {
            Logger.filename = filename;
        }
        public static void log(string message)
        {
            System.IO.File.AppendAllText(filename, message + "\r\n");
        }
    }
}
