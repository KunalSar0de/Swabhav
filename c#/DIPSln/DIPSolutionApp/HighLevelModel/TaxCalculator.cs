using System;
using DIPSolutionApp.CommonModel;

namespace DIPSolutionApp.HighLevelModel
{
    class TaxCalculator
    {
        private  ILogger _logger;
        public TaxCalculator(ILogger logger)
        {
            _logger = logger;
        }

        public int CalculateTax(int val1, int val2)
        {
            try
            {
                int result = val1 / val2;
                return result;
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
            }
            return 0;
        }
    }
}
