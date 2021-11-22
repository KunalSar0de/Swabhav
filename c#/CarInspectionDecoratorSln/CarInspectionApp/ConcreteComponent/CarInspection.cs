using CarInspectionApp.Component;

namespace CarInspectionApp.ConcreteComponent
{
    class CarInspection : ICarService
    {
        private double _price = 600;
        public double GetCost()
        {
            return _price;
        }

        public string GetDetails()
        {
            return $"Car inspection Charge: {_price}";
        }
    }
}
