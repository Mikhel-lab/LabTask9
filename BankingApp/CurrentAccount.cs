using System;
namespace BankingApp
{
    public class CurrentAccount : Account
    {
        protected decimal InteresetRate { get; set; } 
        // protected decimal DepositAmount { get; set; }


        public CurrentAccount(string accountname, string accountnumber,  decimal rate) :base(accountname,accountnumber)
        
        {
            InteresetRate = rate;
        }

         public void Credit(decimal amount)
        {
        if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("You can not deposit amount < 0");
                               
        }

           AccountBalance = AccountBalance + amount;

        }

       
        public void Debit(decimal amount)
       {

          if (amount < 0)
          {
             throw new ArgumentOutOfRangeException("You can not withdraw amount < 0");
          }

            AccountBalance = AccountBalance - amount;
       }

    }
}