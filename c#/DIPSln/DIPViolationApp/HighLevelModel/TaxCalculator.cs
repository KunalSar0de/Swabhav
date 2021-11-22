using System;
using DIPViolationApp.LowLevelModel;

namespace DIPViolationApp.Model
{
    class TaxCalculator
    {
        private LogType _policy;
        public TaxCalculator(LogType logType)
        {
            _policy = logType;
        }

        public int CalculateTax(int val1,int val2)
        {
            try
            {
                int result = val1 / val2;
                return result;
            }catch(Exception ex)
            {
                if (_policy == LogType.DBLogger)
                {
                    new DBLogger().WriteLine(ex.Message);
                }
                else if (_policy == LogType.FileLogger)
                {
                    new FileLogger().WriteLine(ex.Message);
                }
            }
            return 0;
        }
    }
}
