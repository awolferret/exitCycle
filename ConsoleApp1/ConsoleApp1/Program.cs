using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Чтобы закончить введите exit");
                string exitCommand = Console.ReadLine();

                if (exitCommand == "exit")
                {
                    Console.WriteLine("Выход из цикла");
                    break;
                }
            }
        }
    }
}
