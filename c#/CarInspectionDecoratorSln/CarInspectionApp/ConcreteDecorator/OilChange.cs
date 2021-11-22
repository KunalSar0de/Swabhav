using CarInspectionApp.Component;

namespace CarInspectionApp.ConcreteDecorator
{
    class OilChange : ICarService
    {
        private ICarService _service;
        private double _price=150;

        public OilChange(ICarService service)
        {
            _service = service;
        }

        public double GetCost()
        {
            return _price + _service.GetCost();
        }

        public string GetDetails()
        {
            string details = _service.GetDetails();
            details += $"\r\nOil changed Charge : {_price}";
            return details;
        }
       
    }
}
