namespace Package
{
    public class TwoDayPackages : Packages
    {
        decimal twoDayDeliveryFee;

       public decimal TwoDayDeliveryFee
       {
         get { return twoDayDeliveryFee; }
         set { twoDayDeliveryFee = value; }
        }

         public TwoDayPackages( string senderName, string senderAddress,  string senderCity,  string senderState,   string senderZip, string recipientName, string recipientAddress, string recipientCity,  string recipientState,   string recipientZip,  decimal weight, decimal costPerOunce,  decimal twoDayDeliveryFee) : base( senderName, senderAddress, senderCity,  senderState,  senderZip, recipientName,  recipientAddress, recipientCity, recipientState, recipientZip,  weight,  costPerOunce)
        {
          TwoDayDeliveryFee = twoDayDeliveryFee;
        }

        public override decimal CalculateCost()
        {
         return base.CalculateCost() + TwoDayDeliveryFee;
        }
     
     
    
    
  
    
     
     
     
    

    }
}