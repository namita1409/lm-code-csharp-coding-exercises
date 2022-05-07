using System;


namespace Exercises
{
    public class Exercise003
    {

        public string[] IceCreamFlavours = { "Pistachio","Raspberry Ripple",
                                              "Vanilla","Mint Chocolate Chip",
                                              "Chocolate","Mango Sorbet" };

        public int IceCreamCode(String iceCreamFlavour)
        {
            int iceCreamCode = 0;

            for (int i = 0; i < IceCreamFlavours.Length; i++)
            {
                if (iceCreamFlavour == IceCreamFlavours[i]||iceCreamFlavour.Equals(IceCreamFlavours[i]))
                {
                    iceCreamCode = i;
                }
            }
            return iceCreamCode;
        }
    }


}
