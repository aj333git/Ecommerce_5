using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }

            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product {
                        Name = "Football", Description = "Team Game",
                        Category = "outdoor sports", Price = 2275
                    },
                    new Product {
                        Name = "Hockey",
                        Description = "Team Game ",
                        Category = "outdoor sports", Price = 1375
                    },
                    new Product {
                        Name = "Tennis Racket",
                        Description = "Solo Game",
                        Category = "Indoor Sports", Price = 2500
                    },
                    new Product {
                        Name = "Cricket Bat",
                        Description = "Team Game",
                        Category = "outdoor sports", Price = 3500
                    },
                    new Product {
                        Name = "volleyball",
                        Description = "Team Game",
                        Category = "Indoor Sports", Price = 1950
                    },
                    new Product {
                        Name = "Track Suit",
                        Description = "Athletic apparel",
                        Category = "Gears", Price = 3600
                    },
                    new Product {
                        Name = "Boxing Gloves",
                        Description = "Fighter Sports Gear",
                        Category = "Boxing", Price = 800
                    },
                    new Product {
                        Name = "Shin Guard",
                        Description = "Karate Gear",
                        Category = "Karate", Price = 1500
                    },
                    new Product {
                        Name = "Gym Rod",
                        Description = "Gym Must ",
                        Category = "Weight Training", Price = 5000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
