
namespace ShoppingCartLib.Model
{
    public class LineItem
    {
        private int _quantity;
        private Product _product;
        private int _id;
        private double _totalPrice;
        
        public LineItem(int id, Product product, int quantity)
        {
            _quantity = quantity;
            _product = product;
            _id = id;
            Calculate();
        }
        
        public int Quantity
        {
            get
            {               
                return _quantity;
            }
        }
        public Product Product
        {
            get
            {              
                return _product;
            }
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public double Calculate()
        {
            _totalPrice = _product.FinalAmount * _quantity;
            return _totalPrice;
        }  
        public double TotalPrice
        {
            get
            {
                return _totalPrice;
            }
        }

        public override int GetHashCode()
        {            
            return Product.ProductId;
        }
        public override bool Equals(object obj)
        {
            if (this.Product.GetHashCode() == obj.GetHashCode())
                return true;
            return false;
        }
    }
}
