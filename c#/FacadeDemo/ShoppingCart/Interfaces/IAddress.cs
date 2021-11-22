using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Interfaces;
using ShoppingCart.Model;

namespace ShoppingCart.Interfaces
{
    interface IAddress
    {
        Address GetAddressDetails(int userId);

    }
}
