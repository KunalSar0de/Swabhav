using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//string builder vs string in c#
namespace SrpViolation.Model
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
        public void PrintDetails()
        {
            Console.WriteLine("Invoice Id: {0}",_id);
            Console.WriteLine("Invoice Description: {0}", _discription);
            Console.WriteLine("Invoice Amount: {0}", _amount);
            Console.WriteLine("Invoice GST tax: {0}%", _tax);
            Console.WriteLine("Invoice Discount: {0}%", _discount);
            Console.WriteLine("Discounted amount: {0}",CalculateDiscount());
            Console.WriteLine("Tax amount: {0}", CalculateTax());
            Console.WriteLine("Final amount: {0}", CalculateFinalAmount());

        }
    }
}
