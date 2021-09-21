using System;
using System.Collections.Generic;
using System.Text;

namespace Var_and_Dynamic
{
    class VarExample
    {
        internal static void Example()
        {
            var x = 10;
            var y = 20.0;
            var z = "Maria";
            dynamic a = 10;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a.Thiago);
        }
    }
}