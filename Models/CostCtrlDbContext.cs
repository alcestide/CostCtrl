using Microsoft.EntityFrameworkCore;

namespace CostCtrl.Models
{
    public class CostCtrlDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public CostCtrlDbContext(DbContextOptions<CostCtrlDbContext> options)
            : base(options)
        {
            
        }

    }
}
