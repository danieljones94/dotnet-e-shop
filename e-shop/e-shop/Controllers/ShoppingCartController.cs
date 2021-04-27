using e_shop.Interfaces;
using e_shop.Models;
using e_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_shop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ISweetRepository _sweetRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ISweetRepository sweetRepository, ShoppingCart shoppingCart)
        {
            _sweetRepository = sweetRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppinCartViewModel {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int id)
        {
            var sweet = _sweetRepository.GetAllSweets.FirstOrDefault(o => o.Id == id);

            if(sweet != null) {
                _shoppingCart.AddToCart(sweet, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int id)
        {
            var sweet = _sweetRepository.GetAllSweets.FirstOrDefault(o => o.Id == id);

            if (sweet != null) {
                _shoppingCart.RemoveFromCart(sweet);
            }

            return RedirectToAction("Index");
        }
    }
}
