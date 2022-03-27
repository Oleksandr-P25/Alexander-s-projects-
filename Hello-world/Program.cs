using System;

namespace Hello_world_project
{
    struct User {

        public string name;
        public int age;
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("The size of bool is {0}.", sizeof(bool));
            Console.WriteLine("The size of byte is {0}.", sizeof(byte));
            Console.WriteLine("The size of char is {0}.", sizeof(char));
            Console.WriteLine("The size of short is {0}.", sizeof(short));
            Console.WriteLine("The size of int is {0}.", sizeof(int));
            Console.WriteLine("The size of float is {0}.", sizeof(float));
            Console.WriteLine("The size of long is {0}.", sizeof(long));
            Console.WriteLine("The size of double is {0}.", sizeof(double));

            User Tom;
            Tom.age = 23;
            
            Console.WriteLine("The size of struct is {0}.", System.Runtime.InteropServices.Marshal.SizeOf(Tom.age));
            Console.ReadKey();
        }
    }
}
