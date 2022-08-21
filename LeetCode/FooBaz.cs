using System;

namespace LeetCode
{
    public class FooBaz
    {
        public string GetFooBaz(int value)
        {
            Console.WriteLine("-- ok");
            if (value % 5 == 0)
            {
                return "foo";
            }
            else if (value % 5 > 0)
            {
                return "baz";
            }

            return "foobaz";
        }
    }
}
