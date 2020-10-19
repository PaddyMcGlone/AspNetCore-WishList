using WishList.Models;
using Microsoft.EntityFrameworkCore;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
    }
}