using Books.web.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Books.web.DataContext
{
    public class IdentityDb : IdentityDbContext<ApplicationUser>
    {
        public IdentityDb()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

    }
}