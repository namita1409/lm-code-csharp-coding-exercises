using System;
namespace Exercises
{
    public class Exercise004
    {
        
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            double gigaSecond = 1e9;
            return dateTime.AddSeconds(gigaSecond);           
        }
    }
}
