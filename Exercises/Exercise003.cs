using System;
using System.Linq;

namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours = new string[] { "Pistachio", "Raspberry Ripple", 
                                                        "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet"};

        public int? IceCreamCode(string iceCreamFlavour)
        {
            if (String.IsNullOrEmpty(iceCreamFlavour))
                return null;
            return IceCreamFlavours.ToList().IndexOf(iceCreamFlavour);
        }
    }
}
