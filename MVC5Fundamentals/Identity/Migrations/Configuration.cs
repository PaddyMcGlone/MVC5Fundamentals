using Identity.Models;
using Microsoft.AspNet.Identity;

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
            var hash = new PasswordHasher();
            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser{UserName = "pmcglone", PasswordHash = hash.HashPassword("Password") });

            
        }
    }
}
