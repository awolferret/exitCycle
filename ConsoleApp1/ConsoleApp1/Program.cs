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
                string exit = Console.ReadLine();

                if (exit == "exit")
                {
                    Console.WriteLine("Выход из цикла");
                    break;
                }
            }
        }
    }
}
