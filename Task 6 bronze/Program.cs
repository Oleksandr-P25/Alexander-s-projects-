using System;

namespace Task_6_bronze
{
    class Program
    {
        interface ITalk 
        {void talk();}

        interface IEat 
        {void eat();}

        interface IDrink
        {void drink();}

        interface ISleep
        {void sleep();}
        class Animal
            {
                public void walk()
                {
                Console.WriteLine("animal to walk");
                }
            }
        
        class Dog : Animal, ITalk, IEat, IDrink, ISleep
            {
                public void talk()
                {
                    Console.WriteLine("Wooff");
                }
                public void eat()
                {
                    Console.WriteLine("Nyam");
                }
                public void drink()
                {
                    Console.WriteLine("I drink");
                }
                public void sleep()
                {
                    Console.WriteLine("I sleep");
                }
            }  
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.walk();
            dog.talk();
            dog.drink();
            dog.eat();
            dog.sleep();
            Console.ReadLine();
        }
    }
}
