using System;


namespace ProductApp.Model
{
    

    class Product
    {
        private int _id;
        private string _productName;
        private float _price;
        private float _discount;
        private static  int _count = 0;


        static Product()
        {
            _count = 0;
            Console.WriteLine("Static constructor call");
        }
        public Product(int id, string name, float price)
        {
            _id = id;
            _productName = name;
            _price = price;
            _discount = 0.2f;
            _count+=1;
            Console.WriteLine("\nconstructor 1 call");
        }

        public Product(int id, string name, float price, float discount)
        {
            _id = id;
            _productName = name;
            _price = price;
            _discount = discount;
            _count+=1;
            Console.WriteLine("constructor 2 call");
        }

        


        public int ProductId
        {
            get
            {
                return _id;
            }
        } 
        public string GetPName
        {
            get
            {
                return _productName;
            }
        }
        public double GetPrice
        {
            get
            {
                return _price;
            }
        }
        public double CalculateFinalPrice()
        {
            return (_price - ((_price * _discount) / 100));
        }
        public  int GetInstanceCount
        {
            get
            {
                return _count;
            }
        }
        public static int GetCount
        {
            get
            {
                return _count;
            }
        }
        public double Discount
        {
            
            set
            {
                float price = _price;
                _price = (_discount / price) * 100;
            }
            get
            {
                return _price;
            }
        }
    }
}

