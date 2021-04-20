using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CofFeeShop.Models
{
    public interface ICoffeeRepository
    {
        IEnumerable<Coffee> AllCoffees { get; }

        IEnumerable<Coffee> CoffeesOfTheWeek { get; }

        Coffee GetCoffeeById(int coffeeId);

    }
}
