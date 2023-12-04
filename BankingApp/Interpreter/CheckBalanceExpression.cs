using BankingApp.Models;
using System;

namespace BankingApp.Interpreter
{
    // Expression for checking the account balance and displaying it on the console
    public class CheckBalanceExpression : Expression
    {
        /* 
         * Shows the account balance on the console
         * account > The account to check
        */
        public void Interpret(Account account)
        {
            Console.WriteLine($"Your balance is: ${account.Balance}");
        }
    }
}