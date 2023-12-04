using BankingApp.Models;

namespace BankingApp.Interpreter
{
    // Defines the contract for expression classes that interpret and perform operations  on an account
    public interface Expression
    {
        /*
         * Interprets the expression and performs the action on the provided account
         * amount > The account on which the expression operation is performed
        */
        void Interpret(Account account);
    }
}