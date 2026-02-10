using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpenseUseCase
{
    public ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

        return new ResponseRegisteredExpenseJson();
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        var TitleIsEmpty = string.IsNullOrEmpty(request.Title);

        if (TitleIsEmpty)
            throw new ArgumentException("Title is required.");
        if (request.Amount <= 0)
            throw new ArgumentException("Amount must be greater than zero.");
        //var resultData = DateTime.Compare(request.Date, DateTime.UtcNow);
        //if (resultData > 0)
        //    throw new ArgumentException("Date cannot be in the future.");
        //ou
        if (request.Date > DateTime.Now)
            throw new ArgumentException("Date cannot be in the future.");
        if (!Enum.IsDefined(typeof(PaymentType), request.PaymentType))
            throw new ArgumentException("Invalid payment type.");
    }
}