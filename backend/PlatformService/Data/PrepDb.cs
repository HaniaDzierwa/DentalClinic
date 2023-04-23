using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlatformService.Model;
using Microsoft.EntityFrameworkCore;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder applicationBuilder,bool isProd)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(),isProd);
            }
        }

        private static void SeedData(AppDbContext context, bool isProd)
        {
            if(isProd)
            {
                Console.WriteLine("attempt to applay migrations..");
                try {
                    context.Database.Migrate();
                }
                catch(Exception ex) {
                    Console.WriteLine($"cant write migarations : {ex.Message}");
                }
            }
            if (!context.Platforms.Any())
            {
                Console.WriteLine("seeding data");
                context.Platforms.AddRange(
                    new Platform() { Name="dotnet",},
                    new Platform() { Name="tab",},
                    new Platform() { Name="hania",}
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("We already have data");
            }
        }
    }
}