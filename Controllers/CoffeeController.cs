using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CofFeeShop.Models;
using CofFeeShop.ViewModel;

namespace CofFeeShop.Controllers
{
    public class CoffeeController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;
        private readonly ICategoryRepository _categoryRepository;

        public CoffeeController(ICoffeeRepository coffeeRepository, ICategoryRepository categoryRepository)
        {
            _coffeeRepository = coffeeRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            CoffeesListViewModel coffeesListViewModel = new CoffeesListViewModel();
            coffeesListViewModel.Coffees = _coffeeRepository.AllCoffees;
            coffeesListViewModel.CurrentCategory = "Expresso blends";



            return View(coffeesListViewModel);
        }

        public IActionResult Details(int Id)
        {

            var coffee = _coffeeRepository.GetCoffeeById(Id);

            return View(coffee);


        }

    }
}
