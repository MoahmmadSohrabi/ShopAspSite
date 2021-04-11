using Microsoft.EntityFrameworkCore;
using MyShopSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopSite.Data
{
    public class MyShopSiteContext:DbContext
    {
        public MyShopSiteContext(DbContextOptions<MyShopSiteContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryToProduct> CategoryToProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryToProduct>()
               .HasKey(t => new { t.ProductId, t.CategoryId });


            //modelBuilder.Entity<Product>(
            //    p => {
            //        p.HasKey(w => w.Id);
            //        p.OwnsOne<Item>(w => w.Item);
            //        p.HasOne<Item>(w => w.Item).WithOne(w => w.Product).
            //        HasForeignKey<Item>(w => w.Id);
            //    });

            modelBuilder.Entity<Item>(
                i => {
                    i.Property(w => w.Price).HasColumnType("Money");
                    i.HasKey(w => w.Id);
                });

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "لوازم برقی",
                Description = "تجهیزات خانگی"
            },
            new Category()
            {
                Id = 2,
                Name = "خوراکی ها",
                Description = " همراه با تخفیف ویژه"
            },
            new Category()
            {
                Id = 3,
                Name = "پوشاک",
                Description = "تنوع پوشاک مردانه و زنانه"
            },
            new Category()
            {
                Id = 4,
                Name = " زیورآلات",
                Description = "شامل بدلیجات،نقره و طلا"
            }

            );

            modelBuilder.Entity<Item>().HasData(
               new Item()
               {
                   Id = 1,
                   Price = 23000,
                   QuantityInStock = 25

               },
                new Item()
                {
                    Id = 2,
                    Price = 100000,
                    QuantityInStock = 45

                },
                  new Item()
                  {
                      Id = 3,
                      Price = 350000,
                      QuantityInStock = 60

                  }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    ItemId = 1,
                    Name = "جاروبرقی",
                    Description = "همراه با تخفیف 20%این کالا محصول کشور کره می باشد "
                },
                  new Product()
                  {
                      Id = 2,
                      ItemId = 2,
                      Name = "برنج ایرانی",
                      Description = "برنج شمال کشور ایران "
                  },
                    new Product()
                    {
                        Id = 3,
                        ItemId = 3,
                        Name = "تی شرت مردانه",
                        Description = "تی شرت مردانه با تنوع رنگ بندی و ارسال رایگان به همه ی شهر ها"
                    }
                );
            modelBuilder.Entity<CategoryToProduct>().HasData(
                new CategoryToProduct() { CategoryId = 1, ProductId = 1 },
                new CategoryToProduct() { CategoryId = 2, ProductId = 1 },
                new CategoryToProduct() { CategoryId = 3, ProductId = 1 },
                new CategoryToProduct() { CategoryId = 1, ProductId = 2 },
                new CategoryToProduct() { CategoryId = 2, ProductId = 2 },
                new CategoryToProduct() { CategoryId = 3, ProductId = 2 },
                new CategoryToProduct() { CategoryId = 1, ProductId = 3 },
                new CategoryToProduct() { CategoryId = 2, ProductId = 3 },
                new CategoryToProduct() { CategoryId = 3, ProductId = 3 }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
