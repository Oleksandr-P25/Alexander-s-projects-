using System;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int i = rand.Next(10);

            int count=1;

            Console.WriteLine("Комп’ютер загадав число вiд 0 до 9. Спробуйте вгадати його з трьох спроб.");
            Console.WriteLine("Спроба № 1 :");

            int k = Convert.ToInt32(Console.ReadLine());

             while (count <=3)
            {
                if (i == k)
                 {
                Console.WriteLine("Так! Комп’ютер загадав число "+k+"!");
                break;
                 }
              else
                 {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine("На жаль, ви не вгадали число. Це було число " + i + "!");
                        break;
                    }
                    Console.WriteLine("Нi, це не число " + k + "! Спроба № "+ count+":");
                    k = Convert.ToInt32(Console.ReadLine()); 
                 }  
            }
            Console.ReadLine();
        }
    }
}
