using System;
namespace BankingApp
{
    public abstract class Account
    {
        public string AccountName { get; set; }

       public int AccountNumber { get; set; }

       public decimal AccountBalance;
      

       protected Account(string accountname, int accountnumber,  decimal accountbalance)
       {
         AccountName = accountname;
         AccountNumber = accountnumber;
         AccountBalance = accountBalance;
       }

      


        public virtual void Balance()
        {
           Console.WriteLine("Account Owner:{0}, Account Number:{1}, AccountBalance:{2}",
            this.AccountName, this.AccountNumber, this.AccountBalance);
   
           Console.WriteLine("Interest Amount:{0}", CalculateInterest());
        }


    }

}


