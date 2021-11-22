using System;

namespace CollectionApp.Model
{
    class LineItem
    {
        private string _productName;
        private double _price;
        private int _qut;

        public LineItem(string productname,double price,int quentity)
        {
            _productName = productname;
            _price = price;
            _qut = quentity;
        }

        public double TotalPrice()
        {
            _price = _price * _qut;
            return _price;
        }
        public string ProductName
        {
            get
            {
                return _productName;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public int Que
        {
            get
            {
                return _qut;
            }
        }
    }
}
