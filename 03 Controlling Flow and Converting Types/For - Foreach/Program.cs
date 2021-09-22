using System;

namespace For___Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int y = 1; y <= 10; y++)
            {
                Console.WriteLine(y);
            }

            string[] names = {"Adam", "Barry", "Charlie"};
            
            foreach (string name in names)
            {
                Console.WriteLine($"\n{name} has {name.Length} characters.");
            }
        }
    }
}
