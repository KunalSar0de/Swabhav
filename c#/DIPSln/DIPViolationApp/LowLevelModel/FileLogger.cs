using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LowLevelModel
{
    class FileLogger
    {
        internal void WriteLine(string message)
        {
            Console.WriteLine("Logging to File");
            Console.WriteLine(message);
        }
        
    }
}
