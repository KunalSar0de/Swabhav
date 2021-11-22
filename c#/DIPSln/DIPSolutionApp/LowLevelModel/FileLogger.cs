using System;
using DIPSolutionApp.CommonModel;

namespace DIPSolutionApp.LowLevelModel
{
    class FileLogger:ILogger
    {
        public void Log(string messege)
        {
            Console.WriteLine("Logging to File");
            Console.WriteLine(messege);
        }
    }
}
