using Microsoft.AspNetCore.Identity;
using Book_ShopUI.Constants;

namespace Book_ShopUI.Data
{
    public class DbSeeder
    {
        //3.2 Seeding
        public static async Task SeedDefaultData(IServiceProvider service)
        {
            var userMgr = service.GetService<UserManager<IdentityUser>>();
            var roleMgr = service.GetService<RoleManager<IdentityRole>>();

            //adding some role to database

           await roleMgr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
           await roleMgr.CreateAsync(new IdentityRole(Roles.User.ToString()));

            //defautlt admin record

            var admin = new IdentityUser
            {
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                EmailConfirmed = true
            };

            var userInDb = await userMgr.FindByEmailAsync(admin.Email);
            
            if (userInDb is null) 
            {
                await userMgr.CreateAsync(admin,"@Admin12345");
                await userMgr.AddToRoleAsync(admin,Roles.Admin.ToString());
            }


        }
    }
}
