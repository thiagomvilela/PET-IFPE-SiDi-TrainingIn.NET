using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("\r\n");

            int c = 10;
            int d = ++c;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine("\r\n");

            int e = 10;
            int f = e--;
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine("\r\n");

            int g = 10;
            int h = --g;
            Console.WriteLine(g);
            Console.WriteLine(h);
        }
    }
}