using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;



namespace Expense_Tracker.Database
{
    public class ExpensesDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }


        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options)
            : base(options)
        {

        }
    }
}
