﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitCommand;
            string exit = "exit";

            do
            {
                Console.WriteLine($"Чтобы закончить введите {exit}");
                exitCommand = Console.ReadLine();
            }
            while (exitCommand != exit);
            Console.WriteLine("Выход из цикла");
        }
    }
}