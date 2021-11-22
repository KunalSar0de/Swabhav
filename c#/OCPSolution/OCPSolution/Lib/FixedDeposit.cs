
namespace OCPSolution.Model
{
    class FixedDeposit
    {
        private string _name;
        private double _amount;
        private int _duration;
        private IFestivalPolicy _festivalPolicy;
        private double _simpleIntrest;

        public FixedDeposit(string name, double amount, int duration, IFestivalPolicy festivalPolicy)
        {
            _name = name;
            _amount = amount;
            _duration = duration;
            _festivalPolicy = festivalPolicy;    
        }
        public double SimpleIntrest()
        {
            double intrest = _amount * (1 + _duration * _festivalPolicy.CalculateRate() / 100);            
            return _simpleIntrest = intrest - _amount; ;
        }
       
        public double Amount
        {
            get { return _amount; }
        }
        public int Duration
        {
            get { return _duration; }
        }
    }
}
