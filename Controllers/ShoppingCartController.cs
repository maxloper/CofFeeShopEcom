using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CofFeeShop.Models;
using CofFeeShop.ViewModel;


namespace CofFeeShop.Controllers
{

    public class ShoppingCartController : Controller
    {
        private readonly ICoffeeRepository _coffeeRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ICoffeeRepository coffeeRepository, ShoppingCart shoppingCart)
        {
            _coffeeRepository = coffeeRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int coffeeId)
        {
            var selectedCoffee = _coffeeRepository.AllCoffees.FirstOrDefault(p => p.CoffeeId == coffeeId);

            if (selectedCoffee != null)
            {
                _shoppingCart.AddToCart(selectedCoffee, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int coffeeId)
        {
            var selectedCoffee = _coffeeRepository.AllCoffees.FirstOrDefault(p => p.CoffeeId == coffeeId);

            if (selectedCoffee != null)
            {
                _shoppingCart.RemoveFromCart(selectedCoffee);
            }
            return RedirectToAction("Index");
        }
    }
}


