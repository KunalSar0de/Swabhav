using System;
using DIPSolutionApp.CommonModel;

namespace DIPSolutionApp.LowLevelModel
{
    class DBLogger:ILogger
    {
        public void Log(string messege)
        {
            Console.WriteLine("Logging to DB");
            Console.WriteLine(messege);
        }
    }
}
