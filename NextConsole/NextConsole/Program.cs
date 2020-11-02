using System;

namespace NextConsole
{
    class Program
    {
        public static int opt;
        static void Main(string[] args)
        {
            Console.WriteLine("Getting Connection ...");

            var datasource = @"DISLIKEPC\SQLEXPRESS";//your server
            var database = "Sample3"; //your database name
            var username = ""; //username of server to connect
            var password = ""; //password

            //your connection string 
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            //create instanace of database connection
            SqlConnection conn = new SqlConnection(connString);


            try
            {
                Console.WriteLine("Openning Connection ...");

                //open connection
                conn.Open();

                Console.WriteLine("Connection successful!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.Read();


            string opt;
            do
            {
                Console.WriteLine("Select the number of your choice: ");
                Console.WriteLine("1: Add a item");
                Console.WriteLine("2: Remove a item");
                Console.WriteLine("3: print the list");
                Console.WriteLine("4: Quit");
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
                    PrintList.print_list();
                }
                if (opt == "4")
                {
                    Environment.Exit(0);
                }
            } while (true);

        }
    }
}
