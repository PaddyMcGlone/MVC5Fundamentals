using Books.entities;
using System.Data.Entity;

namespace Books.web.DataContext
{
    public class BooksDb: DbContext
    {
        public BooksDb() :base("DefaultConnection")
        {
            
        }

        public DbSet<book> Books { get; set; }
    }
}