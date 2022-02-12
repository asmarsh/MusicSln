using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace MusicStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
            .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new Product
                {
                    Name = "Bass Drum",
                    Description = "Loud.  Can be used in a drum kit.",
                    Category = "Percussion",
                    Price = 275
                },
                new Product
                {
                    Name = "Cowbell",
                    Description = "Famous for Foghat's 'Slow Ride' and SNL sketches.",
                    Category = "Percussion",
                    Price = 48.95m
                },
                new Product
                {
                    Name = "Fender Stratocaster",
                    Description = "What most people think of when they think of electric guitars.",
                    Category = "Guitar",
                    Price = 19.50m
                },
                new Product
                {
                    Name = "Gibson Les Paul",
                    Description = "The other thing that people think of when they think of electric guitars.",
                    Category = "Guitar",
                    Price = 34.95m
                }, new Product
                {
                    Name = "Prince's Cloud",
                    Description = "One of a kind.  Famous for Prince's 'Purple Rain.'",
                    Category = "Guitar",
                    Price = 79500
                },
                new Product
                {
                    Name = "Music Theory for Dummies",
                    Description = "Your bandmates may make fun of you, but they'll secretly be jealous.",
                    Category = "Books",
                    Price = 16
                },
                new Product
                {
                    Name = "Beethoven's Fifth Sheet Music",
                    Description = "The classical music song that everyone knows.",
                    Category = "Books",
                    Price = 29.95m
                },
                new Product
                {
                    Name = "Music for 18 Musicians Sheet Music",
                    Description = "The classical music series that nobody knows.",
                    Category = "Books",
                    Price = 75
                },
                new Product
                {
                    Name = "Moog Synthesizer",
                    Description = "Technically a piano, maybe?",
                    Category = "Piano",
                    Price = 16
                },
                new Product
                {
                    Name = "Yamaha Grand Piano",
                    Description = "Incredible action and dynamic range available at a surprisingly reasonable pricepoint.",
                    Category = "Piano",
                    Price = 29.95m
                },
                new Product
                {
                    Name = "Korg Keyboard",
                    Description = "Beloved by touring musicians all over the world.",
                    Category = "Piano",
                    Price = 75
                }
                );
                context.SaveChanges();
            }
        }
    }
}