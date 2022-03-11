using System;

namespace HansJohnnysButikApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu runProgram = new Menu();
            runProgram.run();
            Console.WriteLine("\nTryck på valfri tangent för att avsluta programmet.");
            Console.ReadKey(true);
        }       
    }
}
