using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
using RedLightGreenLight.Models;

namespace RedLightGreenLight.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
