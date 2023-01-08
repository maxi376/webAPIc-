using Microsoft.EntityFrameworkCore;

namespace WEBapi.Models
{
    public class UsermContext : DbContext
    {
        public UsermContext(DbContextOptions<UsermContext> options)
            : base(options)
        {
        }

        public DbSet<Userm> Userms { get; set; } = null!;
        public DbSet<Device> Devices { get; set; } = null!;
    }
}
