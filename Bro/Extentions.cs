using System;

namespace Bro
{
    public class Extentions
    {
        public bool Swap(string str)
        {
            if (str.Length > 0)
            {
                return true;
            }

            return false;
        }

        public void Foo(int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine("foo");
            }
            else
            {
                Console.WriteLine("baz");
            }
        }
    }
}
