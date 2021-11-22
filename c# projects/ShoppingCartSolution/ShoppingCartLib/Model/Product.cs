

namespace ShoppingCartLib.Model
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discount;
        private double _finalAmount;
  
        public Product(int pId, string pName, double pPrice, float pDiscount)
        {
            _id = pId;
            _name = pName;
            _price = pPrice;
            _discount = pDiscount;
            DiscountedPrice(_price);
        }

        public int ProductId
        {
            get 
            { 
                return _id; 
            }
        }
        public string ProductName
        {
            get
            {
                return _name;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
        public float ProductDiscount
        {
            get
            {
                return _discount;
            }
        }
        public double DiscountedPrice(double amount)
        {           
            _finalAmount = _discount / 100 * amount;
            return _finalAmount;
        }
        public double FinalAmount
        {
            get
            {
                return _finalAmount;
            }
        }
        public override int GetHashCode()
        {
            return ProductId;
        }
        public override bool Equals(object obj)
        {
            if(this.ProductId==obj.GetHashCode())
                return true;
            return false;
        }
    }
}
