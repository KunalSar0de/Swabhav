using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynkProgrammingApproch
{
    public class TimePrinter
    {
        public void Print()
        {
            DateTime startTime = DateTime.UtcNow;
            TimeSpan future = TimeSpan.FromMinutes(0.16);
            while (DateTime.UtcNow - startTime < future)
            {
                Debug.WriteLine("delay : " + DateTime.Now.ToString("hh,mm,ss"));
            }
            Debug.WriteLine("delay over");
        }

        internal Task<int> PrintAsync()
        {
            return Task.Run(() =>
            {
                Print();
                return 10;
            });
        }
    }
}
