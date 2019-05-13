using System;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddSomething(350, 70);
        }
        private static void AddSomething(int x,int y)
        {
            int sum = x + y;
            Console.WriteLine("The Sum is " + sum);
            Console.ReadLine();
        }
        private static void SubtractSomething(int x, int y)
        {
            int diff = x - y;
            Console.WriteLine("The Difference is " + diff);
            Console.ReadLine();
        }
        private static void DivideSomething(int x, int y)
        {
            int rem = x / y;
            Console.WriteLine("The Remainder is " + diff);
            Console.ReadLine();
        }
    }
}
