using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace e_shop.Models
{
    public class ShoppingCart
    {

        private readonly AppDbContext _appDbContext;
        public string Id { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { Id = cartId };
        }

        public void AddToCart(Sweet sweet, int quantity)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(o => o.Sweet.Id == sweet.Id && o.ShoppingCartId == Id);

            if (shoppingCartItem == null) {
                shoppingCartItem = new ShoppingCartItem {
                    ShoppingCartId = Id,
                    Sweet = sweet,
                    Quantity = quantity
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else {
                shoppingCartItem.Quantity++;
            }

            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Sweet sweet)
        {
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(o => o.Sweet.Id == sweet.Id && o.ShoppingCartId == Id);

            int quantity = 0;

            if (shoppingCartItem != null) {
                if (shoppingCartItem.Quantity > 1) {
                    shoppingCartItem.Quantity--;
                    quantity = shoppingCartItem.Quantity;
                }
                else {
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return quantity;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where(o => o.ShoppingCartId == Id)
                .Include(s => s.Sweet)
                .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCartItems.Where(o => o.ShoppingCartId == Id);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShoppingCartItems.Where(o => o.ShoppingCartId == Id).Select(o => o.Sweet.Price * o.Quantity).Sum();

            return total;
        }

    }
}
