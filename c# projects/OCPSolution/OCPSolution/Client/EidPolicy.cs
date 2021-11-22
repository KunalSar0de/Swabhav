using OCPSolution.Model;

namespace OCPSolution.Client
{
    class EidPolicy : IFestivalPolicy 
    { 
        public double CalculateRate()
        {
            return  8.5;
        }
    }
}
