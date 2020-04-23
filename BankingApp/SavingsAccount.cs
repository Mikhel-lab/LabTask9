using System;
namespace BankingApp
{
    public class SavingsAccount : Account
    {
        protected decimal InteresetRate { get; set; } 
        protected decimal DepositAmount { get; set; }


        public SavingsAccount(string accountname, int accountnumber, decimal rate) :base(accountname,accountnumber)
        
        {
            InteresetRate = rate;
            
        }

         public  void Credit(decimal amount)
        {
           if (amount < 0)
        {
            throw new ArgumentOutOfRangeException("You can not deposit amount < 0");
                               
        }

           AccountBalance = AccountBalance + InteresetRate;

        }

       
         public void Debit(decimal amount)
         {

          if (amount < 0)
          {
             throw new ArgumentOutOfRangeException("You can not withdraw amount < 0");
          }

            AccountBalance = AccountBalance - amount;
       }

        public decimal CalculateInterest()
       {
           return (this.AccountBalance * this.InteresetRate) / 100;
       }
    }
}