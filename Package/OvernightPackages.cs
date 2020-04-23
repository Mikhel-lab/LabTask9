namespace Package
{
   public class OvernightPackages : Packages
   {
        decimal OvernightDelivery;

        public decimal OvernightDeliveries
        {
          get { return OvernightDelivery; }
          set { OvernightDelivery = value; }
        }

        public OvernightPackages( string senderName, string senderAddress,  string senderCity,  string senderState,   string senderZip, string recipientName, string recipientAddress, string recipientCity,  string recipientState,   string recipientZip,  decimal weight, decimal costPerOunce,  decimal OvernightDelivery) : base( senderName, senderAddress, senderCity,  senderState,  senderZip, recipientName,  recipientAddress, recipientCity, recipientState, recipientZip,  weight,  costPerOunce)
        {
            
           OvernightDelivery = OvernightDelivery;
        }

         public override decimal CalculateCost()
        {
          return (CostPerOunce + OvernightDelivery) * Weight;
        }
        
    }
}