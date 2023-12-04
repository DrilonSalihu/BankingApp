using BankingApp.Interpreter;
using BankingApp.Models;
using System.Security.Principal;
using Xunit;

public class BankingAppTests
{
    [Fact]
    /*
     * > Creates an `Account` object with a balance of 100
     * > Initializes a `Context` object with the account
     * > Creates an instance of `CheckBalanceExpression`
    */
    public void CheckBalanceExpression_Should_Display_Balance()
    {
        // Arrange
        Account account = new Account { Balance = 100 };
        Context context = new Context(account);
        Expression checkBalanceExpression = new CheckBalanceExpression();

        // Act
        checkBalanceExpression.Interpret(account);
    }

    [Fact]
    /*
     * This functions the very same as CheckBalanceExpression_Should_Display_Balance
     * but focueses on withdrawing instead of checking the balance
     * > Creates an `Account` object with a balance of 100
     * > Initializes a `Context` object with the account
     * > Creates an instance of `CheckBalanceExpression`
     * > Asserts that after a withdrawal of 50, the account balance should be 50
    */
    public void WithdrawExpression_Should_Withdraw_Correct_Amount()
    {
        // Arrange
        Account account = new Account { Balance = 100 };
        Context context = new Context(account);
        Expression withdrawExpression = new WithdrawExpression(50);

        // Act
        withdrawExpression.Interpret(account);

        // Assert
        Assert.Equal(50, account.Balance);
    }

    [Fact]
    // > Tests the withdrawal expression when there are insufficient funds (the balance is 20)
    public void WithdrawExpression_Should_Display_Insufficient_Funds_Message()
    {
        // Arrange
        Account account = new Account { Balance = 20 };
        Context context = new Context(account);
        Expression withdrawExpression = new WithdrawExpression(50);

        // Act
        withdrawExpression.Interpret(account);

        // Assert
    }

    [Fact]
    /*
     * > Tests the deposit expression
     * > Asserts that after depositing $50, the account balance should be $150
    */
    public void DepositExpression_Should_Deposit_Correct_Amount()
    {
        // Arrange
        Account account = new Account { Balance = 100 };
        Context context = new Context(account);
        Expression depositExpression = new DepositExpression(50);

        // Act
        depositExpression.Interpret(account);

        // Assert
        Assert.Equal(150, account.Balance);
    }

    [Fact]
    /*
     * > Tests the deposit expression when the deposit amount is negative.
    */
    public void DepositExpression_Should_Handle_Invalid_Deposit_Amount()
    {
        // Arrange
        Account account = new Account { Balance = 100 };
        Context context = new Context(account);
        Expression depositExpression = new DepositExpression(-50);

        // Act
        depositExpression.Interpret(account);

        // Assert
    }
}
