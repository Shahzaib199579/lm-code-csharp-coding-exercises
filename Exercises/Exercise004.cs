using System;
namespace Exercises
{
    public class Exercise004
    {
        public const int GIGA_SECOND = 1000000000;
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            return dateTime.AddSeconds(GIGA_SECOND);
        }
    }
}
