using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankingApp.Models;

namespace BankingApp.Interpreter
{
    // Represents the context in which an interpretation operation is performed
    public class Context
    {
        // Gets or sets the account associated with the current context
        public Account Account { get; set; }

        /* 
         * Initializes a new instance of the class with the specified account
         * account > The account to associate with the context
        */
        public Context(Account account)
        {
            Account = account;
        }
    }
}