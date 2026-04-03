namespace Validators.Tests.Expenses.Register;   

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request = new RequestRegisterExpenseJson
        {
            Title = "Expense Title",
            Amount = 100,
            Description = "Description",
            Date = DateTime.Now.AddDays(-1),
            PaymentType = PaymentType.CreditCard
        };
        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.True(result.IsValid);
    }
}   