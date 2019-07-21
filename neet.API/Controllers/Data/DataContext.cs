 using Microsoft.EntityFrameworkCore;
using neet.API.Controllers.models;

namespace neet.API.Controllers.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
 
        public DbSet<Value> Values { get; set; }
    }
}