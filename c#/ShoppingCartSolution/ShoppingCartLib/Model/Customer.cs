using System;
using System.Collections.Generic;


namespace ShoppingCartLib.Model
{
    public class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _order=new List<Order>();
        private int _orderCount;
        private double _customerTotal=0;


        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public void AddOrder(Order order)
        {
            _order.Add(order);
            _orderCount += 1;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public List<Order> Order
        {
            get
            {
                return _order;
            }
        }
        public int OrderCount
        {
            get
            {
                return _orderCount;
            }
        }
        public double CustomerTotal()
        {
            foreach(var items in Order)
            {
                _customerTotal += items.GetOrderTotalProp;                
            }
            return _customerTotal;
        }
    }
}
