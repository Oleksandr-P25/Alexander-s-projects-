using System;

namespace Task_5_gold
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop.Products apple = new Shop.Products("Apple", 12);
                                
            Shop.Products orang = new Shop.Products("Orang", 30);
                       
            Shop.Products banana = new Shop.Products("Banana", 25);
            
            bool i = true;
            
            string action;
            
            Console.WriteLine("Введiть товари зi списку: " + "Apple, Orang, Banana");
            Console.WriteLine("Щоб видалити товари з чеку введiть команду - Clear");
            Console.WriteLine("Щоб купити вибранi товари введiть команду - Buy");

            while (i == true)
            {
                
                action = Console.ReadLine();

            switch (action)
            {
                case "Apple":
                    apple.product();
                    break;
                
                case "Orang":
                    orang.product();
                    break;

                case "Banana":
                    banana.product();
                    break;

                case "Clear":
                    Shop.Grocery_store.clearChek();
                    break;

                case "Buy":
                    i = false;
                    break;
                case "Delete":

                default:
                    Console.WriteLine("Не вiрна назва товару");
                    break;
                }
            }
            
            Shop.Grocery_store.chek();
            Shop.Grocery_store.sum();
        }
    }
}
