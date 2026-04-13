using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;

namespace CommonTestUtilities.Requests;
public class RequestRegisterExpenseJsonBuilder
{
    public static RequestRegisterExpenseJson Build()
    {
        //return new RequestRegisterExpenseJson
        //{
        //    Amount = 100,
        //    Description = string.Empty,
        //    Title = "Test",
        //    Date = DateTime.Now.AddDays(-1),
        //    PaymentType = CashFlow.Communication.Enums.PaymentType.CreditCard
        //};
        return new Bogus.Faker<RequestRegisterExpenseJson>()
            .RuleFor(x => x.Amount, f => f.Random.Decimal(min: 1, max: 1000))
            .RuleFor(x => x.Description, f => f.Lorem.Sentence())
            .RuleFor(x => x.Title, f => f.Commerce.Product())
            .RuleFor(x => x.Date, f => f.Date.Past())
            .RuleFor(x => x.PaymentType, f => f.PickRandom<PaymentType>());

    }
}
