using Microsoft.EntityFrameworkCore;


namespace e_shop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Sweet> Sweets { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Chocolate" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Fruit Sweets" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Gummy Sweets" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, Name = "Halloween Sweets" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 5, Name = "Hard Boiled Sweets" });

            modelBuilder.Entity<Sweet>().
                HasData(new Sweet {
                    Id = 1,
                    Name = "Assorted Chocolate",
                    Price = 4.99m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 1,
                    ImageUrl = "\\images\\chocolateSweets.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\chocolateSweets-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 2,
                    Name = "Assorted Chocolate 2",
                    Price = 3.99m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 1,
                    ImageUrl = "\\images\\chocolateSweets2.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\chocolateSweets2-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 3,
                    Name = "Assorted Chocolate 3",
                    Price = 2.99m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 1,
                    ImageUrl = "\\images\\chocolateSweets3.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\chocolateSweets3-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 4,
                    Name = "Assorted Fruit Sweets",
                    Price = 1.99m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 2,
                    ImageUrl = "\\images\\fruitSweets.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\fruitSweets-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 5,
                    Name = "Assorted Fruit Sweets 2",
                    Price = 4.99m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 2,
                    ImageUrl = "\\images\\fruitSweets2.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\fruitSweets2-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 6,
                    Name = "Assorted Fruit Sweets 3",
                    Price = 1.49m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 2,
                    ImageUrl = "\\images\\fruitSweets3.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\fruitSweets3-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 7,
                    Name = "Assorted Gummy Sweets 2",
                    Price = 0.59m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 3,
                    ImageUrl = "\\images\\gummySweets.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\gummySweets-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 8,
                    Name = "Assorted Gummy Sweets",
                    Price = 1.49m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 3,
                    ImageUrl = "\\images\\gummySweets2.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\gummySweets2-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 9,
                    Name = "Assorted Gummy Sweets 3",
                    Price = 6.19m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 3,
                    ImageUrl = "\\images\\gummySweets3.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\gummySweets3-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 10,
                    Name = "Assorted Halloween Sweets",
                    Price = 3.49m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 4,
                    ImageUrl = "\\images\\halloweenSweets.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\halloweenSweets-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 11,
                    Name = "Assorted Halloween Sweets 2",
                    Price = 2.49m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 4,
                    ImageUrl = "\\images\\halloweenSweets2.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\halloweenSweets2-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 12,
                    Name = "Assorted Halloween Sweets 3",
                    Price = 8.99m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 4,
                    ImageUrl = "\\images\\halloweenSweets3.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\halloweenSweets3-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 13,
                    Name = "Assorted Hard Boiled Sweet",
                    Price = 1.99m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 5,
                    ImageUrl = "\\images\\hardSweets.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\hardSweets-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 14,
                    Name = "Assorted Hard Boiled Sweets 2",
                    Price = 3.19m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 5,
                    ImageUrl = "\\images\\hardSweets2.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\hardSweets2-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });

            modelBuilder.Entity<Sweet>()
                .HasData(new Sweet {
                    Id = 15,
                    Name = "Assorted Hard Boiled Sweets 3",
                    Price = 0.99m,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    CategoryId = 5,
                    ImageUrl = "\\images\\hardSweets3.jpg",
                    ImageThumbNailUrl = "\\images\\thumbnails\\hardSweets3-small.jpg",
                    IsInStock = true,
                    IsOnSale = true
                });




        }
    }
}
