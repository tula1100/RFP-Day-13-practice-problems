using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refractor_1
{
    internal class Refactor_to_generic
    {
        public static T FindMax<T>(T a, T b, T c) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 || a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 || a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                Console.WriteLine(a);
            }

            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                Console.WriteLine(b);
            }

            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 || c.CompareTo(a) >= 0 && c.CompareTo(b) > 0 || c.CompareTo(a) > 0 && c.CompareTo(b) >= 0)
            {
                Console.WriteLine(c);
            }
            return a;
        }

    }
}
