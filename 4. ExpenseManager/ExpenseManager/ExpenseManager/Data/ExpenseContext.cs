using Microsoft.EntityFrameworkCore;
using ExpenseManagerApp.Models;

namespace ExpenseManagerApp.Data
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
    }
}
