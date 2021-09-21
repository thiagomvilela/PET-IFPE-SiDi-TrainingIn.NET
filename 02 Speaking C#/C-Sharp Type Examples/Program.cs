using System;
using System.Globalization;

namespace C_Sharp_Type_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            double valorDecimalDouble = 10.35783;
            float valorDecimalFloat = 2.43f;
            int num = 32;
            long numLong = 32L;
            string nome = "Maria";
            char caracter = 'F';

            int num2 = default(int);

            Console.WriteLine(num2);
            Console.WriteLine("O valor é " + valorDecimalDouble.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("O valor é " + valorDecimalDouble.ToString("F1"));

            Console.WriteLine("\r\n " + valorDecimalDouble + " " + num + "  " + nome);

            Console.WriteLine("\r\nInT max " + int.MaxValue);
            Console.WriteLine("InT min" + int.MinValue);
        }
    }
}