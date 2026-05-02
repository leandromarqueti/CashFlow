using Microsoft.EntityFrameworkCore;
using CashFlow.Domain.Entities; 

namespace CashFlow.Infrastructure.DataAccess;
public class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses{ get; set; }

    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflow_db;Uid=root;Pwd=@password123;";
        var version = new Version(8, 0, 45);
        var serverVersion = new MySqlServerVersion(version);
        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}
