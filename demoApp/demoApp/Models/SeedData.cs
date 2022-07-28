using Microsoft.EntityFrameworkCore;
using demoApp.Data;

namespace demoApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new demoAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<demoAppContext>>()))
            {
                if (context == null || context.Customer == null)
                {
                    throw new ArgumentNullException("Null demoAppContext");
                }

                // Look for any movies.
                if (context.Customer.Any())
                {
                    return;   // DB has been seeded
                }

                context.Customer.AddRange(
                    new Customer
                    {
                        FirstName = "FIRSTNAMETEST",
                        LastName = "LASTNAMETEST",
                        Birthday = DateTime.Parse("1989-2-12"),
                        Product = "PRODUCT1",
                        InvestmentValue = 7.99M
                    }

                    
                );
                context.SaveChanges();
            }
        }
    }
}
