using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses;
public interface IExpensesReadOnlyRepository
{
    public Task<Expense?> GetById(long id);
    public Task<List<Expense>> GetAll();
    public Task<List<Expense>> FilterByMonth(DateOnly month);
}
