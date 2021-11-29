
using System;

namespace CalculatorLib
{
    public class Calculator
    {
        public event Action<string,int, int, double> OnAdditionOperationComplete = null;
        public event Action<string, int, int,double> OnSubtractionOperationComplete = null;
        public void Add(int a,int b)
        {
            var add = a + b;
            if (OnAdditionOperationComplete != null)
            {
                OnAdditionOperationComplete("Addition",a,b,add);
            }
        }
        public void Subtract(int a, int b)
        {
            var sub = a - b;
            if (OnSubtractionOperationComplete != null)
            {
                OnSubtractionOperationComplete("Subtraction",a,b,sub);
            }
        }
    }
}
