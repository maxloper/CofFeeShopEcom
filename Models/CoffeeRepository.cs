using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CofFeeShop.Models
{
 
    public class CoffeeRepository:ICoffeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public CoffeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Coffee> AllCoffees
        {
            get
            {
                return _appDbContext.Coffees.Include(c => c.Category);
            }
        }

        public IEnumerable<Coffee> CoffeesOfTheWeek
        {
            get
            {
                return _appDbContext.Coffees.Include(c => c.Category).Where(p => p.IsCoffeeOfTheWeek);
            }
        }

        public Coffee GetCoffeeById(int coffeeId)
        {
            return _appDbContext.Coffees.FirstOrDefault(p => p.CoffeeId == coffeeId);
        }
    }
}
