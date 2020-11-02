using ReCourseWork.Controller;

using System;
using System.Data.SqlClient;

namespace ReCourseWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");


            string connString = Properties.Settings.Default.ConStr;
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                Console.WriteLine("Openning Connection ...");

                conn.Open();

                Console.WriteLine("Connection successful!");

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }


            do
            {
                Console.WriteLine("Select the number of your choice: ");
                Console.WriteLine("1: Add a item");
                Console.WriteLine("2: Remove a item");
                Console.WriteLine("3: print the list");
                Console.WriteLine("4: Update the item ");
                Console.WriteLine("5:Quit");
                Console.WriteLine("select main item :");

                
                string opt_ = Console.ReadLine();
                int opt;

                while (!int.TryParse(opt_, out opt))
                {
                    Console.WriteLine("This is not a number");
                    opt_ = Console.ReadLine();
                    Console.WriteLine();
                }

                if (opt > 0 && opt < 6 )
                {

                    if (opt == 1)
                    {
                        VehicleController.AddItem();
                        Console.WriteLine();

                    }
                    if (opt == 2)
                    {
                        VehicleController.DeleteItem();
                        Console.WriteLine();
                    }
                    if (opt == 3)
                    {
                        VehicleController.PrintItem();
                        Console.WriteLine();
                    }
                    if (opt == 4)
                    {
                        VehicleController.UpdateItem();
                        Console.WriteLine();

                    }
                    if (opt == 5)
                    {
                        Environment.Exit(0);
                    }
                   
                }
                else
                {
                    Console.WriteLine("invalid option ...");
                    Console.WriteLine("This is not a number");
                    opt_ = Console.ReadLine();

                }

            } while (true) ;

        }
    }
}
