using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyItemExternalLib;

namespace ShoppingCartClientApp.Model
{
    class HatToItemAdapter : IItem
    {
        private Hat _hat;

        public HatToItemAdapter(Hat hat)
        {
            _hat = hat;
        }

        public string ItemName()
        {
            return _hat.GetShortName;

        }

        public double ItemPrice()
        {
            return _hat.Price;
        }

        
    }
}
