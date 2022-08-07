using System;

namespace LeetCode
{
    public class FooBaz
    {
        public string GetFooBaz(int value)
        {
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
