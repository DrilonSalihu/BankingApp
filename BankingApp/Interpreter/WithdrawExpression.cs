using BankingApp.Models;
using System;

namespace BankingApp.Interpreter
{
    // Represents an expression for withdrawing money from an account
    public class WithdrawExpression : Expression
    {
        private readonly decimal withdrawalAmount;

        /*
         * Initializes a new instance of the class with the specified withdrawal amount
         * withdrawalAmount > The amount to withdraw 
        */
        public WithdrawExpression(decimal withdrawalAmount)
        {
            this.withdrawalAmount = withdrawalAmount;
        }

        /* 
         * Interprets the expression to withdraw money from the provided account.
         * account > The account to withdraw money from
         * 
         * If the bank account has a balance of $0 or less, they can't withdraw any amount whatsoever
        */
        public void Interpret(Account account)
        {
            if (account.Balance >= withdrawalAmount)
            {
                account.Balance -= withdrawalAmount;
                Console.WriteLine($"Withdrawal of ${withdrawalAmount} successful. Remaining balance: ${account.Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. You don't have enough funds for the withdrawal.");
            }
        }
    }
}