using System;
using System.Collections.Generic;
using System.Text;

namespace NextConsole
{
    class AddItem
    {
        public static string option;
        static readonly int maxStore = 10;
        public static List<Vehicle> shop = new List<Vehicle>();
        public static void add_item()
        {
            if (shop.Count <= maxStore)
            {
                Console.WriteLine("select the option :");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("CAR SECTION");
                    Console.WriteLine("get ID :");
                    string ID = Console.ReadLine();

                    Console.WriteLine("get brand :");
                    string brand = Console.ReadLine();

                    Console.WriteLine("get owner :");
                    string owner = Console.ReadLine();

                    Console.WriteLine("get price :");
                    string price = Console.ReadLine();

                    Console.WriteLine("get seat :");
                    string seat = Console.ReadLine();

                    Car c = new Car();
                    c.getId = ID;
                    c.getBrand = brand;
                    c.getOwner = owner;
                    c.getPrice = price;
                    c.getSeats = seat;
                    shop.Add(c);

                }
                if (option == "2")
                {

                    Console.WriteLine("BIKE SECTION");
                    Console.WriteLine("get ID :");
                    string ID = Console.ReadLine();

                    Console.WriteLine("get brand :");
                    string brand = Console.ReadLine();

                    Console.WriteLine("get owner :");
                    string owner = Console.ReadLine();

                    Console.WriteLine("get price :");
                    string price = Console.ReadLine();

                    Console.WriteLine("get color :");
                    string color = Console.ReadLine();

                    Bike b = new Bike();
                    b.getId = ID;
                    b.getBrand = brand;
                    b.getOwner = owner;
                    b.getPrice = price;
                    b.getColour = color;
                    shop.Add(b);
                }

            }
            else
            {
                Console.WriteLine("no space there");
            }
        }
    }
}
