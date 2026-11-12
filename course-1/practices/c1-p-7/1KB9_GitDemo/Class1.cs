namespace _1KB9_GitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            if (number > 0)
            {
                Console.WriteLine("Число положительное");
            } 
            else if (number < 0)
            {
                Console.WriteLine("Число отрицательное");
            } 
            else
            {
                Console.WriteLine("Число равно нулю");
            }

            Console.Write("Введите ваш возраст: ");
            int age = int.Parse(Console.ReadLine());

            if (age => 18)
            {
                Console.WriteLine("Вы совершеннолетний");
            } 
            else
            {
                Console.WriteLine("Вы несовершеннолетний");
            }

            int num = 7;

            if (num % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }

            int a = 5;
            int b = -2;

            if (a > 0 && b > 0)
            {
                Console.WriteLine("Оба числа положительные");
            }
            else if (a > 0 || b > 0)
            {
                Console.WriteLine("Хотя бы одно число положительное");
            }
            else if (a < 0) 
            {
                Console.WriteLine("А не положительное");
            }

            Console.Write("Введите вашу оценку: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade < 3)
            {
                Console.WriteLine("Неудовлетворительно");
            }
            else if (grade == 3)
            {
                Console.WriteLine("Удовлетворительно");
            }
            else if (grade == 4)
            {
                Console.WriteLine("Хорошо");
            }
            else if (grade == 5)
            {
                Console.WriteLine("Отлично");
            }
        }
    }
}
