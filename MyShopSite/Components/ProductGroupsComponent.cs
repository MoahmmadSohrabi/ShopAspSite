using Microsoft.AspNetCore.Mvc;
using MyShopSite.Data;
using MyShopSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopSite.Components
{
    public class ProductGroupsComponent:ViewComponent
    {
        private MyShopSiteContext _context;
        public ProductGroupsComponent(MyShopSiteContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _context.Categories
                .Select(c => new ShowGroupViewModel()
                {
                    GroupId=c.Id,
                    Name=c.Name,
                    ProductCount=_context.CategoryToProducts.Count(g=>g.CategoryId==c.Id)
                }).ToList();
            return View("/Views/Components/ProductGroupsComponent.cshtml", categories);
        }
    }
}
