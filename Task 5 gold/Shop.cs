using System;

namespace Shop
{
    class Grocery_store 
    {
                public static void sum ()
        {
            float pdv = (_sum * 20) / 100;
            float profit  = _sum - pdv;
            Console.WriteLine("Сума   " + _sum + "\r\n" + "Прибуток = " + profit);
        }

        public static void chek ()
        {
            Console.WriteLine("\r\n" + Shop.Grocery_store._chek);
        }

        public static void clearChek  ()
        {
            _sum = 0;
            _chek = null;
        }
        protected static float _sum = 0;
        protected static string _chek = null;

        //int counter = 0;
        
         /*public static Products New_prosuct () 
        {                      
            Products prod = new Products();       

            Console.WriteLine("Введiть назву продукту");
            Products._ProductName = (Console.ReadLine());

            Console.WriteLine("Введiть цiну продукту");
            Products._Price = int.Parse(Console.ReadLine());

            Console.WriteLine(Products._ProductName + "   " + Products._Price + " грн.");
            return prod;
        }*/
        //public enum pruct_list {Apple, Orang}
    }

    class Products : Grocery_store
        {
            public Products(string _ProductName, int _Price)
            {                          
                ProductName = _ProductName;
                Price = _Price;
            }
            public string ProductName;
            public int Price;

            public void product ()
            {            
            _sum += Price;
            _chek += ProductName + "  " + Price + "\r\n";
            }

           
        }

    
}