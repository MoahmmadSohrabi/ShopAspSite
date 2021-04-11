using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopSite.Models
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            CartItems = new List<CartItem>();
        }
        public List<CartItem> CartItems { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
