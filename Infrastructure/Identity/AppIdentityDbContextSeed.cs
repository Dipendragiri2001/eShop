using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Dipen",
                    Email = "Dipen@gmail.com",
                    UserName = "Dipen@gmail.com",
                    Address = new Address
                    {
                        FirstName = "Dipen",
                        LastName = "Giri",
                        Streets = "Lekhnath Chowk",
                        City = "Jhapa",
                        State = "Mechi",
                        ZipCode ="57200"
                    }

                };
                await userManager.CreateAsync(user, "p@$$w0Rd");
            }
        }
    }
}