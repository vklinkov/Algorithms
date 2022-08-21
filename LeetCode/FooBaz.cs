using System;

namespace LeetCode
{
    public class FooBaz
    {
        public int GetFooBaz(string value)
        {
            var result = 5;

            if (value == "foo")
            {
                result = 1;
            }

            return result;
        }
    }
}
