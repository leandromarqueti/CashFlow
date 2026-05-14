using CashFlow.Domain.Repositories;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.UseCases.Expenses.Delete;
public class DeleteExpenseUseCase : IDeleteExpenseUseCase
{
    private readonly IExpensesReadOnlyRepository _expensesReadOnly;
    private readonly IExpensesWriteOnlyRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteExpenseUseCase(
        IExpensesWriteOnlyRepository repository,
        IExpensesReadOnlyRepository expensesReadOnly,
        IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
        _expensesReadOnly = expensesReadOnly;
    }

    public async Task Execute(long id)
    {

        var expense = await _expensesReadOnly.GetById(id);
        if (expense is null)
        {
            throw new NotFoundException(ResourceErrorMessages.EXPENSE_NOT_FOUND);
        }

        await _repository.Delete(id);

        await _unitOfWork.Commit();
    }
}