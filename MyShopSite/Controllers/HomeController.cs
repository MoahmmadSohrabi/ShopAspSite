using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyShopSite.Data;
using MyShopSite.Models;

namespace MyShopSite.Controllers
{
    public class HomeController : Controller
    {
        private MyShopSiteContext _context;
        private static Cart _cart = new Cart();

        public HomeController(MyShopSiteContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var products = _context.Products
               .ToList();
            return View(products);
        }
        [Route("ContactUs")]
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AddToCart(int itemId)
        {
            var product = _context.Products.Include(p => p.Item).SingleOrDefault(p => p.ItemId == itemId);
            if (product != null)
            {
                var cartItem = new CartItem()
                {
                    Item = product.Item,
                    Quantity = 1
                };
                _cart.addItem(cartItem);
            }
            return RedirectToAction("ShowCart");

        }
        public IActionResult ShowCart()
        {
            var CartVM = new CartViewModel()
            {
                CartItems = _cart.CartItems,
                OrderTotal = _cart.CartItems.Sum(c => c.getTotalPrice())
            };
            return View(CartVM);
        }
        public IActionResult RemoveCart(int ItemId)
        {
            _cart.removeItem(ItemId);
            return RedirectToAction("ShowCart");

        }
        public IActionResult Detail(int id)
        {
            var product = _context.Products
                .Include(p => p.Item)
                .SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            var categories = _context.Products.
                Where(p => p.Id == id)
                .SelectMany(c => c.CategoryToProducts)
                .Select(ca => ca.Category)
                .ToList();

            var vm = new DetailsViewModel()
            {
                Product = product,
                Categories = categories
            };
            return View(vm);
            
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
