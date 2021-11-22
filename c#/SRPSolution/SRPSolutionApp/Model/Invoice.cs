

namespace SRPSolutionApp.Model
{
    class Invoice
    {
        private int _id;
        private string _discription;
        private double _amount;
        private float _tax;
        private float _discount;
        private float _discountAmount;
        private float _taxAmount;
        private float _finalAmount;

        public Invoice(int id,string disc,double amount,float tax,float discount)
        {
            _id = id;
            _discription = disc;
            _amount = amount;
            _tax = tax;
            _discount = discount;
        }

        public double CalculateDiscount()
        {
            _discountAmount=(float)_discount / 100 * (float)_amount;
            return _discountAmount;
        }
        public double CalculateTax()
        {
            _taxAmount = _tax / 100 *(float) _amount;
            return _taxAmount;
        }
        public double CalculateFinalAmount()
        {
            double initialAmount = (float)_amount - _discountAmount;
            _finalAmount = (float)initialAmount + _taxAmount;
            return _finalAmount;
        }
     
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Discprition
        {
            get
            {
                return _discription;
            }
        }
        public double Amount
        {
            get
            {
                return _amount;
            }
        }
        public double DiscountOnInvoice
        {
            get
            {
                return _discount;
            }
        }
        public double TaxOnInvoice
        {
            get
            {
                return _tax;
            }
        }
        public double DiscountedPrice
        {
            get
            {
                return _discountAmount;
            }
        }
        public double FinalAmount
        {
            get
            {
                return _finalAmount;
            }
        }
    }
}
