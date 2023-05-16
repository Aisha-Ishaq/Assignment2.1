using Microsoft.EntityFrameworkCore;
using Watch_zen.Shared.Models;

namespace Watch_zen.Server.Data
{
    public class Appdbcontext : DbContext
    {
        public Appdbcontext(DbContextOptions<Appdbcontext> options) : base(options)
        {

        }
        public DbSet<ProductInfo> Product { get; set; }
    }
}
