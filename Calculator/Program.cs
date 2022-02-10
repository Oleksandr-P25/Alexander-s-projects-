using System;

namespace Project__hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Введiть число 1");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введiть число 2");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Виберiть операцiю: '+' '-' '*' '/'");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Помилка!");
                    }
                    else
                    {
                    Console.WriteLine(firstValue / secondValue);
                    }
                    break;
                default:
                    Console.WriteLine("Помилка! Невiдома дiя");
                    break;
            }
            Console.ReadLine();
        }
    }
}
