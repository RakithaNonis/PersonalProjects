using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class AddItem
    {
        public static string option;
        static readonly int maxStore = 10;
        public static List<Vehicle> shop = new List<Vehicle>();
        public static void add_item()
        {
            SqlConnection conn;
            string connString = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connString);
            conn.Open();

            string sql = "";

            if (shop.Count <= maxStore)
            {
                Console.WriteLine("select the option :");
                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.WriteLine("CAR SECTION");
                    Console.WriteLine("get user ID :");
                    int UID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("get brand :");
                    string brand = Console.ReadLine();

                    Console.WriteLine("get owner :");
                    string owner = Console.ReadLine();

                    Console.WriteLine("get price :");
                    decimal price = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("get seat :");
                    string seat = Console.ReadLine();

                    Car c = new Car();
                    c.getUserId = UID;
                    c.getBrand = brand;
                    c.getOwner = owner;
                    c.getPrice = price ;
                    c.getSeats = seat;
                    shop.Add(c);


                    //sql = "insert into demo values(@ID,@brand,@owner,@price)";
                    //cmd = new SqlCommand(sql, conn);
                    //adap.InsertCommand = new SqlCommand(sql, conn);


                    string query = "INSERT INTO demo (UserId,Brand,Owner,Price) VALUES (@UID,@brand,@owner, @price)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UID", c.getUserId);
                    cmd.Parameters.AddWithValue("@brand", c.getBrand);
                    cmd.Parameters.AddWithValue("@owner", c.getOwner);
                    cmd.Parameters.AddWithValue("@price", c.getPrice);


                    //cmd = new SqlCommand(query, conn);
                    // use to execute the DML statement against 
                    // our database 
                    //SqlDataAdapter adap = new SqlDataAdapter(query,conn);
                    //adap.InsertCommand.ExecuteNonQuery();

                    cmd.ExecuteNonQuery();
                }
                if (option == "2")
                {

                    Console.WriteLine("BIKE SECTION");
                    Console.WriteLine("get user ID :");
                    int UID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("get brand :");
                    string brand = Console.ReadLine();

                    Console.WriteLine("get owner :");
                    string owner = Console.ReadLine();

                    Console.WriteLine("get price :");
                    decimal price = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("get color :");
                    string color = Console.ReadLine();


                    Bike b = new Bike();
                    b.getUserId = UID;
                    b.getBrand = brand;
                    b.getOwner = owner;
                    b.getPrice = price;
                    b.getColour = color;
                    shop.Add(b);

                    string query = "INSERT INTO demo (UserId,Brand,Owner,Price) VALUES (@UID,@brand,@owner, @price)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UID", b.getUserId);
                    cmd.Parameters.AddWithValue("@brand", b.getBrand);
                    cmd.Parameters.AddWithValue("@owner", b.getOwner);
                    cmd.Parameters.AddWithValue("@price", b.getPrice);

                    cmd.ExecuteNonQuery();

                }


            }

            {
                Console.WriteLine("no space there");
            }

        }
    }
}
