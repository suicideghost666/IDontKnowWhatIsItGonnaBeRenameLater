using Microsoft.EntityFrameworkCore;
namespace DeadInside.Infrastructure
{
    public class DeadContext : 
        DbContext
    {
        public DeadContext(DbContextOptions options) : base(options)
        {
        }
    }
}
