using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LowLevelModel
{
    class DBLogger
    {
        internal void WriteLine(string message)
        {
            Console.WriteLine("Logging to DB");
            Console.WriteLine(message);
        }
    }
}
