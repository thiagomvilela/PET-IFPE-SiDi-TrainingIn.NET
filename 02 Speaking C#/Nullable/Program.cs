using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numNaoNull = 3;

            //int? numNull = null;
            //numNull = 3;

            //if (numNull is int valueOfNum)
            //if (numNull != null)
            // {
            //Console.WriteLine($"num is {valueOfNum}");
            //Console.WriteLine($"num is {numNull.Value}");

            // }
            //else
            //  {
            //Console.WriteLine("Não tem valor");
            //}
            //int m = numNull ?? 10;

            //Console.WriteLine(m);

            //int numNaoNull = 3;

            //int? numNull = null;
            //int m = (int) numNull;

            //int? numNull = null;
            //int m = numNull ?? 10;

            int? numNull = null;
            int m = numNull.GetValueOrDefault();

            Console.WriteLine(m);

        }
    }
}