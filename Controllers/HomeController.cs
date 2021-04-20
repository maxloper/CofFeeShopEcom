using CofFeeShop.Models;
using CofFeeShop.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CofFeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;

        public HomeController(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeVIewModel
            {
                CoffeesOfTheWeek = _coffeeRepository.CoffeesOfTheWeek
            };

            return View(homeViewModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
