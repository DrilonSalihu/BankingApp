using BankingApp.Models;
using System;

namespace BankingApp.Interpreter
{
    // Represents an expression for depositing money into an account
    public class DepositExpression : Expression
    {
        private readonly decimal depositAmount;

        /*
         * Initializes a new instance of the class with the specified deposit amount
         * depositAmount > The amount to deposit
         */
        public DepositExpression(decimal depositAmount)
        {
            this.depositAmount = depositAmount;
        }

        /*
         * Interprets the expression to deposit money into the provided account
         * account > The account to deposit money into.
         */
        public void Interpret(Account account)
        {
            account.Balance += depositAmount;
            Console.WriteLine($"Deposit of ${depositAmount} successful. New balance: ${account.Balance}");
        }
    }
}