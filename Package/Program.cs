using System;

namespace Package
{
    class Program
    {
        static void Main(string[] args)
        {
            Packages[] packs = {new TwoDayPackages( "John Kennedy",
          "Auston Avenue",
          "Yaba",   
          "Ikeja",
          "vd 837",
          "Ajax",
          "CC House",
          "Lagos",   
          "Milsh",
          "Yellszz",  
          100M,
          0.6M,
          1.89M ), new OvernightPackages( "John Stuart",
          "Km 20 Gas Line",
          "Annamina",   
          "Mexophina",
          "zm 465",
          "Mike Smilth",
          "43 Austin Avenue",
          "Lamanesh Close",   
          "Ogun",
          "Meelsss",  
          10M,
          0.7M,
          0.09M )};
            foreach (Packages p in packs)
            {
                Console.WriteLine(p.SenderName);
                 Console.WriteLine(p.SenderAddress);
                 Console.WriteLine(p.RecipientAddress);
                 Console.WriteLine(p.SenderCity);
                 Console.WriteLine(p.SenderState);
                 Console.WriteLine(p.SenderZip);
                 Console.WriteLine(p.RecipientState);
                 Console.WriteLine(p.RecipientZip);
                 Console.WriteLine(p.Weight);
                 Console.WriteLine(p.CalculateCost());
            }
       
        }
    }
}
