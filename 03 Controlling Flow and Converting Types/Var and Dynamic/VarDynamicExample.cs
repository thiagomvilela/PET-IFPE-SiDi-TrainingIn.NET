using System;
using System.Collections.Generic;
using System.Text;

namespace Var_and_Dynamic
{
    class VarDynamicExample
    {
        internal static void Example01()
        {
            var x = 10;         // identified in the compilation: int32
            var y = 20.0;       // identified in the compilation: double
            var z = "Thiago";   // identified in the compilation: string

            //dynamic a = 10;     // Compiler identifies at run time

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            //Console.WriteLine(a.Vilela); 
        }
        internal static void Example02()
        {
            //var myVar;
            var myVar = "\nVilela";
            Console.WriteLine(myVar);

            dynamic myDynamic;
            myDynamic = 1;
            Console.WriteLine(myDynamic);
            myDynamic = "https://github.com/thiagomvilela";
            Console.WriteLine(myDynamic);

        }
    }
}