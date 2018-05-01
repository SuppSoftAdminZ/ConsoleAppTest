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
    }
}
