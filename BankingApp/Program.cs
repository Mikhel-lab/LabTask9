
using System;

namespace BankingApp
{
    class Program
    
        static void Main(string[] args)
        {
            Account[] acc ={ new SavingAccount("Sarvesh", "S12345"),new CurrentAccount("Mark", "C12345")};
            foreach (Account a in acc)
            {
                Console.WriteLine("a.Balance");
                Console.WriteLine("a.AccountName");
            }

           
        }
    }
}
