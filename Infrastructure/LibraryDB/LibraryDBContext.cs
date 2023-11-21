
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.LibraryDB
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext(DbContextOptions options) : base(options)
        {
        }
    
        public DbSet<User> users { get; set; }
    

    }
}
