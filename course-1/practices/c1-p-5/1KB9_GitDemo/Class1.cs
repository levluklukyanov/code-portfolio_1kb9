using System;


namespace _1KB9_GitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Вы любите код? ");

                string otvet = (Console.ReadLine() ?? "").ToLower().Trim();
                
                if (otvet == "да")
                {
                    Console.WriteLine("Ура!");
                    break;
                }
                else if (otvet == "нет")
                {
                    Console.WriteLine("Плохой мальчик!");
                    break;
                }
                else
                {
                    Console.WriteLine("Непонятно!");
                }
            }
        }
    }
}