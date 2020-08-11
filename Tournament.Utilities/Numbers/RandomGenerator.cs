
using System;

namespace Tournament.Utilities.Numbers
{
    public class RandomGenerator
    {
        private static Random rand = new Random();

        public RandomGenerator()
        {
        }

        public static int GetNumber()
        {
            if (rand != null)
                return rand.Next(int.MinValue, int.MaxValue);

            rand = new Random();
            return rand.Next(int.MinValue, int.MaxValue);
        }
    }
}
