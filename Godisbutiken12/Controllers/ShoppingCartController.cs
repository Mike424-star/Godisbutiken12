using Godisbutiken12.Models;
using Godisbutiken12.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Godisbutiken12.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IGodisRepository _godisRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IGodisRepository godisRepository, ShoppingCart shoppingCart)
        {
            _godisRepository = godisRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.shoppingCartItems = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToShoppingCart(int godisId)
        {
            var selectedGodis = _godisRepository.GetAllGodis.FirstOrDefault(c => c.GodisID == godisId);
            if (selectedGodis != null)
            {
                _shoppingCart.AddToCart(selectedGodis, 1);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int godisId)
        {
            var selectedGodis = _godisRepository.GetAllGodis.FirstOrDefault(c => c.GodisID == godisId);
            if (selectedGodis != null)
            {
                _shoppingCart.RemoveFromCart(selectedGodis);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
   
}
