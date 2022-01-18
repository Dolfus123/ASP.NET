using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HddStore3.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Toshiba Canvio",
                        Description = "Toshiba",
                        Category = "Встроеный",
                        Price = 150
                    },
                    new Product
                    {
                        Name = "Transcend StoreJet",
                        Description = "Transcend",
                        Category = "Встроеный",
                        Price = 180
                    },
                    new Product
                    {
                        Name = "Western Digital",
                        Description = "Western",
                        Category = "Встроеный",
                        Price = 140
                    },
                    new Product
                    {
                        Name = "Seagate Expansion",
                        Description = "Seagate",
                        Category = "Встроеный",
                        Price = 220
                    },
                    new Product
                    {
                        Name = "Samsung T5",
                        Description = "Samsung",
                        Category = "Встроеный",
                        Price = 220
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
