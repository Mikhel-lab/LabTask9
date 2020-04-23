using System;
namespace Package
{
    public class Packages
    {
        private string senderName;
        private string senderAddress;
        private string senderCity;
        private string senderState;
        private string senderZip;

        private string recipientName;
        private string recipientAddress;
        private string recipientCity;
        private string recipientState;
        private string recipientZip;

        private  decimal weight;
        private  decimal costPerOunce;

         public Packages( string senderName, string senderAddress,  string senderCity,  string senderState,   string senderZip, string recipientName, string recipientAddress, string recipientCity,  string recipientState,   string recipientZip,  decimal weight, decimal costPerOunce)
         {
          SenderName = senderName;
          SenderAddress = senderAddress;
          SenderCity = senderCity;
          SenderState = senderState;
          SenderZip = senderZip;
          RecipientName = recipientName;
          RecipientAddress = recipientAddress;
          RecipientCity = recipientCity;
          RecipientState = recipientState;
          RecipientZip = recipientZip;
          Weight = weight;
          CostPerOunce = costPerOunce;
        }
         public string SenderName
         {
           get{ return senderName; }
           set{ senderName = value; }
        }

       public string SenderAddress
       {
         get{ return senderAddress; }
         set{ senderAddress = value; }
       }

      public string SenderCity
      {
       get{ return senderCity; }
       set{ senderCity = value; }
      }
  
       public string SenderState
      {
       get{ return senderState; }
       set{ senderState = value; }
      }

      public string SenderZip
      {
        get{ return senderZip; }
        set{ senderZip = value; }
      }

      public string RecipientName
      {
        get{ return recipientName; }
        set{ recipientName = value; }
      }

      public string RecipientAddress
      {
        get{ return recipientAddress; }
        set{ recipientAddress = value; }
      }

      public string RecipientCity
      {
        get{ return recipientCity; }
        set{ recipientCity = value; }
      }

      public string RecipientState
      {
        get{ return recipientState; }
        set{ recipientState = value; }
      }

      public string RecipientZip
      {
        get{ return recipientZip; }
        set{ recipientZip = value; }
      }

      public decimal Weight
      {
       get{ return weight; }
       set
       {
        if (value > 0)
          weight = value; 
        else
          Console.WriteLine("Weight can't be less than zero");  
       }
      }
  
        public decimal CostPerOunce
        {
           get{ return costPerOunce; }
           set
          { 
            if (value > 0)
            costPerOunce = value; 
            else
             Console.WriteLine("Cost per ounce can't be less than zero");  
          }

        }


      public virtual decimal CalculateCost()
      {
        return weight * costPerOunce;
      }



    }
  

}