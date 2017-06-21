using Identity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Identity.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Identity.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Identity.Models.ApplicationDbContext context)
        {
            /* The old method of adding users */
            //var hash = new PasswordHasher();
            //context.Users.AddOrUpdate(u => u.UserName,
            //    new ApplicationUser{UserName = "pmcglone", PasswordHash = hash.HashPassword("Password") });


            /* The new method of adding users */
            var store = new UserStore<ApplicationUser>(context);
            var manager = new UserManager<ApplicationUser>(store);
            var user = new ApplicationUser {UserName = "pmcglone", Email = "paddy@home.local"};

            manager.Create(user, "password");
        }
    }
}
