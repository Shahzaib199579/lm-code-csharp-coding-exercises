using System;
using System.Linq;

namespace Exercises
{
    public class Exercise003
    {
        // Replace the exception statement below with your code!
        public string[] IceCreamFlavours = new string[] { "Pistachio", "Raspberry Ripple", 
                                                        "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet"};

        // Replace the exception statement below with your code!
        public int? IceCreamCode(string iceCreamFlavour)
        {
            if (String.IsNullOrEmpty(iceCreamFlavour))
                return null;
            return IceCreamFlavours.ToList().IndexOf(iceCreamFlavour);
        }
    }
}
