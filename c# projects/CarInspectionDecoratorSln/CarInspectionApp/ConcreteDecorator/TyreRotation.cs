using CarInspectionApp.Component;


namespace CarInspectionApp.ConcreteDecorator
{
    class TyreRotation:ICarService
    {
        private ICarService _carService;
        private double _price = 250;
        public TyreRotation(ICarService carService) 
        {
            _carService = carService;
        }

        public double GetCost()
        {
            return _price + _carService.GetCost();
        }

        public string GetDetails()
        {
            string details = _carService.GetDetails();
            details += $"\r\nTyre Rotation Charge : {_price}";
            return details;
        }
      
    }
}
