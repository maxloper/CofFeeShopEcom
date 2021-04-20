using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CofFeeShop.Models;

namespace CofFeeShop.ViewModel
{
    public class HomeVIewModel
    {

        public IEnumerable<Coffee> CoffeesOfTheWeek { get; set; }

    }
}
