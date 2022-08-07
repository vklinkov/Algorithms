using System;

namespace LeetCode
{
    public class FooBaz
    {
        public string GetFooBaz(int value)
        {
            if(value % 5 == 0)
            {
                return "Foo";
            }
            else if (value % 5 > 0)
            {
                return "Baz";
            }
            else
            {
                return "FooBaz";
            }
        }
    }
}
