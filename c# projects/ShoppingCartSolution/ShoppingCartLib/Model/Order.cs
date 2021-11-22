using System;
using System.Collections.Generic;


namespace ShoppingCartLib.Model
{
    public class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> _items=new List<LineItem>();
        private int _itemCount;
        private int _count;
        private double _orderTotal=0;

        public Order(int id, DateTime date)
        {      
            _id = id;
            _date = date;
            _count++;
          
        }
        public void AddItem(LineItem items)
        {   
            _items.Add(items);
            _itemCount += 1;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }
        public List<LineItem> Items
        {
            get
            {
                return _items;
            }
        }
        public int ItemCount
        {
            get
            {
                return _itemCount;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public double GetOrderTotal()
        {
            foreach(var items in Items)
            {               
                _orderTotal += items.TotalPrice;      
            }   
            return _orderTotal;
        }
        public double GetOrderTotalProp
        {
            get
            {
                return _orderTotal;
            }
        }
        
    }
}
