using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp.Model
{
    class ShoppingCart
    {
        private List<IItem> items = new List<IItem>();
        public void AddItem(IItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }
        public double TotalPrice()
        {
            return 0;
        }
        public List<IItem> Items
        {
            get
            {
                return items;
            }
        }
    }
}
