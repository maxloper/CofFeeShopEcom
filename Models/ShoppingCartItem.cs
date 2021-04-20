using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CofFeeShop.Models
{
    public class ShoppingCartItem
    {

        public int ShoppingCartItemId { get; set; }
        public Coffee Coffee { get; set; }

        // amount of coffees added for that certain coffee
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }


    }
}
