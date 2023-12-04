using BankingApp.Interpreter;
using BankingApp.Models;
using System;

namespace BankingApp
{
    // Entry point for the banking application
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new bank account for the user
            Account account = new Account();

            // Create a context with the newly created account
            Context context = new Context(account);

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");

                // Reads the users input
                string choice = Console.ReadLine();

                switch (choice)
                {
                    // If the user types 1, they check their account balance
                    case "1":
                        Expression checkBalanceExpression = new CheckBalanceExpression();
                        checkBalanceExpression.Interpret(account);
                        break;

                    // If the user types 2, they can withdraw money from their bank account
                    case "2":
                        Console.Write("Enter the amount to withdraw: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                        {
                            Expression withdrawExpression = new WithdrawExpression(withdrawalAmount);
                            withdrawExpression.Interpret(account);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for withdrawal amount.");
                        }
                        break;

                    // If the user types 3, they can deposit money into their bank account
                    case "3":
                        Console.Write("Enter the amount to deposit: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            Expression depositExpression = new DepositExpression(depositAmount);
                            depositExpression.Interpret(account);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for deposit amount.");
                        }
                        break;

                    // If the user types 4, they exit the program
                    case "4":
                        Environment.Exit(0);
                        break;

                    /*
                     * If no input has been given or a wrong input has been typed 
                     * (ex. character or number that is not 1 - 4) it returns an error 
                    */
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}