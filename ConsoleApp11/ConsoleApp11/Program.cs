using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        //public static int opt;
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");


            string connString = Properties.Settings.Default.ConStr;
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();



                Console.WriteLine("Connection successful!");
                
                //InsertStatemen.Insert();

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

           // Console.Read();


            string opt;
            do
            {
                Console.WriteLine("Select the number of your choice: ");
                Console.WriteLine("1: Add a item");
                Console.WriteLine("2: Remove a item");
                Console.WriteLine("3: print the list");
                Console.WriteLine("4: Update the item ");
                Console.WriteLine("5:Quit");
                Console.WriteLine("select main item :");
                opt = Console.ReadLine();

                if (opt == "1")
                {
                    AddItem.add_item();
                    
                }
                if (opt == "2")
                {
                    DeleteItem.del_item();
                }
                if (opt == "3")
                {
                    //PrintList.print_list();
                    SelectStatement.Read();
                }
                if (opt == "4")
                {
                    
                    UpdateItem.update_item();
                }
                if (opt == "5")
                {
                    Environment.Exit(0);
                }
            } while (true);
           
        }
    }
}
