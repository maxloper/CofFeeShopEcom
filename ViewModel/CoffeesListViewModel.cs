using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CofFeeShop.Models;

namespace CofFeeShop.ViewModel
{
    public class CoffeesListViewModel
    {

        public IEnumerable<Coffee> Coffees { get; set; }
        public string CurrentCategory { get; set; }



    }
}
