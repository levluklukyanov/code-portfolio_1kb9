using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace _1KB9_GitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Задание 1

            Console.Write("Введите температуру вашей комнаты в цельсиях: ");
            double C = int.Parse(Console.ReadLine());
            double F = C * 9 / 5 + 32;
            Console.WriteLine($"Температура твоей комнаты по фаренгейту: {F}");
            
            //Задание 2

            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int num3 = int.Parse(Console.ReadLine());

            double avg = (double)(num1+num2+num3)/3;

            Console.WriteLine($"Среднее арифметическое чисел {num1}, {num2} и {num3} = {avg}");
            Console.WriteLine("Объяснение: Для того чтобы вычислить среднее арифметическое чисел нужно узнать их сумму и поделить на количество чисел");

            //Задание 3

            Console.Write("Введите первое число: ");
            int calc1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int calc2 = int.Parse(Console.ReadLine());

            while (true) {
                Console.Write("Введите арифметическое действие (+, -, *, /): ");
                string arif = Console.ReadLine();
                
                if (arif == "+") {
                    int sum = calc1 + calc2;
                    Console.WriteLine($"Сумма заданных чисел = {sum}");
                    break;
                } else if (arif == "-") {
                    int sub = calc1 - calc2;
                    Console.WriteLine($"Разность заданных чисел = {sub}");
                    break;
                } else if (arif == "*") {
                    int mul = calc1 * calc2;
                    Console.WriteLine($"Произведение заданных чисел = {mul}");
                    break;
                } else if (arif == "/") {
                    int div = calc1 / calc2;
                    Console.WriteLine($"Частное (целое) заданных чисел = {div}");
                    double div2 = (double)calc1/calc2;
                    Console.WriteLine($"Частное (точное) заданных чисел = {div2}");
                    break;
                } else
                {
                    Console.WriteLine("Неизвестное арифметическое действие!");
                    continue;
                }
            }
        }
    }
}
