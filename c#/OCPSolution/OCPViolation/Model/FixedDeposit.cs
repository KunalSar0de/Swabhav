using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation.Model
{
    class FixedDeposit
    {
        private string _name;
        private double _amount;
        private int _duration;
        private double _rate;
        private FestivalType _festival;
        private double _simpleIntrest;


        public FixedDeposit(string name,double amount,int duration,FestivalType festival)
        {
            _name = name;
            _amount = amount;
            _duration = duration;
            _festival = festival;
            CalculateRate(festival);
        }

        public double SimpleIntrest()
        {
            _simpleIntrest = _amount * (1+_duration * _rate/100);
            double intrest = _simpleIntrest - _amount;
            return intrest;
        }
        public double CalculateRate(FestivalType type)
        {
            if (FestivalType.NEW_YEAR == type)
            {
                _rate = 9.5;
                return _rate;
            }
            else if(FestivalType.DIWALI == type)
            {
                _rate = 8;
                return _rate;
            }
            else if (FestivalType.DIWALI == type)
            {
                _rate = 9;
                return _rate;
            }
            else if(FestivalType.NORMAL==type)
            {
                _rate = 7;
                return _rate;
            }
            return _rate;
        }
        public double Amount
        {
            get { return _amount; }
        }
    }
}
