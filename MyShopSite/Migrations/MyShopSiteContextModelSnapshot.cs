// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyShopSite.Data;

namespace MyShopSite.Migrations
{
    [DbContext(typeof(MyShopSiteContext))]
    partial class MyShopSiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyShopSite.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "تجهیزات خانگی",
                            Name = "لوازم برقی"
                        },
                        new
                        {
                            Id = 2,
                            Description = " همراه با تخفیف ویژه",
                            Name = "خوراکی ها"
                        },
                        new
                        {
                            Id = 3,
                            Description = "تنوع پوشاک مردانه و زنانه",
                            Name = "پوشاک"
                        },
                        new
                        {
                            Id = 4,
                            Description = "شامل بدلیجات،نقره و طلا",
                            Name = " زیورآلات"
                        });
                });

            modelBuilder.Entity("MyShopSite.Models.CategoryToProduct", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("CategoryId");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryToProducts");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("MyShopSite.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("Money");

                    b.Property<int>("QuantityInStock");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 23000m,
                            QuantityInStock = 25
                        },
                        new
                        {
                            Id = 2,
                            Price = 100000m,
                            QuantityInStock = 45
                        },
                        new
                        {
                            Id = 3,
                            Price = 350000m,
                            QuantityInStock = 60
                        });
                });

            modelBuilder.Entity("MyShopSite.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("ItemId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "همراه با تخفیف 20%این کالا محصول کشور کره می باشد ",
                            ItemId = 1,
                            Name = "جاروبرقی"
                        },
                        new
                        {
                            Id = 2,
                            Description = "برنج شمال کشور ایران ",
                            ItemId = 2,
                            Name = "برنج ایرانی"
                        },
                        new
                        {
                            Id = 3,
                            Description = "تی شرت مردانه با تنوع رنگ بندی و ارسال رایگان به همه ی شهر ها",
                            ItemId = 3,
                            Name = "تی شرت مردانه"
                        });
                });

            modelBuilder.Entity("MyShopSite.Models.CategoryToProduct", b =>
                {
                    b.HasOne("MyShopSite.Models.Category", "Category")
                        .WithMany("CategoryToProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyShopSite.Models.Product", "Product")
                        .WithMany("CategoryToProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyShopSite.Models.Product", b =>
                {
                    b.HasOne("MyShopSite.Models.Item", "Item")
                        .WithOne("Product")
                        .HasForeignKey("MyShopSite.Models.Product", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
