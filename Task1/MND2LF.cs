using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public static class MND2LF
    {
        public static Y Calculate<X, Y>(this X[] n, Func<X, Y> d)
        {
            return d(n[n.Length / 2]);

        }
    }
}
