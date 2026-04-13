using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Enums;
using CashFlow.Exception;
using CommonTestUtilities.Requests;
using FluentAssertions;

namespace Validators.Tests.Expenses.Register;
public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();

        //var request = new RequestRegisterExpenseJson
        //{
        //    Amount = 100,
        //    Description = string.Empty,
        //    Title = "Test",
        //    Date = DateTime.Now.AddDays(-1),
        //    PaymentType = CashFlow.Communication.Enums.PaymentType.CreditCard
        //};

        var request = RequestRegisterExpenseJsonBuilder.Build();

        //Act
        var result = validator.Validate(request);

        //Assert
        //Assert.True(result.IsValid);

        result.IsValid.Should().BeTrue();
    }

    [Fact]
    public void Error_TitleEmpty()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();

        var request = RequestRegisterExpenseJsonBuilder.Build();
        //request.Title = string.Empty;

        //Act
        var result = validator.Validate(request);

        //Assert
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(err => err.ErrorMessage.Equals(ResourceErrorMessages.TITLE_REQUIRED));
    }

    [Fact]
    public void Error_Date_Future()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();

        var request = RequestRegisterExpenseJsonBuilder.Build();
        //request.Date = DateTime.UtcNow.AddDays(1);

        //Act
        var result = validator.Validate(request);

        //Assert
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(err => err.ErrorMessage.Equals(ResourceErrorMessages.EXPENSES_CANNOT_FOR_THE_FUTURE));
    }

    [Fact]
    public void Error_PaymentType_Invalid()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();

        var request = RequestRegisterExpenseJsonBuilder.Build();
        //request.PaymentType = (PaymentType)700;

        //Act
        var result = validator.Validate(request);

        //Assert
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(err => err.ErrorMessage.Equals(ResourceErrorMessages.PAYMENT_TYPE_INVALID));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Error_Amount_Invalid(decimal amount)
    {
        //Arrange
        var validator = new RegisterExpenseValidator();

        var request = RequestRegisterExpenseJsonBuilder.Build();
        //request.Amount = amount;

        //Act
        var result = validator.Validate(request);

        //Assert
        result.IsValid.Should().BeFalse();
        result.Errors.Should().ContainSingle().And.Contain(err => err.ErrorMessage.Equals(ResourceErrorMessages.AMOUNT_MUST_BE_GREATER_THAN_ZERO));
    }

}
