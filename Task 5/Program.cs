using System;

namespace Task_5
{
    class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}

        public void PrintName()
        {
            Console.WriteLine($"Мене звати {FirstName}");
        }
    }

    class Store_employee : Person
    {
        public void Cashier()
        {
            Console.WriteLine("Я вмiю пробивати товари");
        }

        public void Accountant()
        {
            Console.WriteLine("Я вмiю рахувати кошти");
        }

        public void Manager()
        {
            Console.WriteLine("Я вмiю робити звiти");
        }
    }

    class Client : Person
    {
        public void Shopper()
        {
            Console.WriteLine("Я вмiю купувати товари");
        }
    }
    class Program
    {

        public static void Main(string[] args)
        {
            Store_employee employee = new Store_employee();
            employee.FirstName = "Alex";
            employee.PrintName();
            employee.Cashier();
       
            Store_employee employee1 = new Store_employee();
            employee1.FirstName = "Oleg";
            employee1.PrintName();
            employee1.Manager();

            Client client1 = new Client();
            client1.FirstName = "Anna";
            client1.PrintName();
            client1.Shopper();

            Console.ReadLine();
        }
    }
}
