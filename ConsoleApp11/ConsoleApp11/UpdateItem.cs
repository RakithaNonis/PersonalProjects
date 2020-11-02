using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class UpdateItem
    {
        public static void  update_item() 
        {
            SqlConnection conn;
            string connString = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connString);
            conn.Open();

            Console.WriteLine("give the user id :");
            string updt_id = Console.ReadLine();


            Console.WriteLine("give the update element \n 1) brand 2)owner 3)price  :");
            int ele_num = Convert.ToInt32(Console.ReadLine());

            if (ele_num == 1)
            {
                Console.WriteLine("give the update brand :");
                string u_brand = Console.ReadLine();

                string qryB = "UPDATE demo SET Brand=@Brand where UserId=@" + updt_id;
                SqlCommand cmd = new SqlCommand(qryB, conn);
                cmd.Parameters.AddWithValue("@Brand", u_brand);
                cmd.Parameters.AddWithValue("@" + updt_id, updt_id);
                cmd.ExecuteNonQuery();
            }
            if (ele_num == 2) 
            {
                Console.WriteLine("give the update owner :");
                string u_owner = Console.ReadLine();

                string qryO = "UPDATE demo SET Owner=@Owner where UserId=@" + updt_id;
                SqlCommand cmd = new SqlCommand(qryO, conn);
                cmd.Parameters.AddWithValue("@Owner", u_owner);
                cmd.Parameters.AddWithValue("@" + updt_id, updt_id);
                cmd.ExecuteNonQuery();
            }
            if (ele_num == 3) 
            {
                Console.WriteLine("give the update price :");
                string u_price = Console.ReadLine();

                string qryP = "UPDATE demo SET Price=@Price where UserId=@" + updt_id;
                SqlCommand cmd = new SqlCommand(qryP, conn);
                cmd.Parameters.AddWithValue("@Price", u_price);
                cmd.Parameters.AddWithValue("@" + updt_id, updt_id);
                cmd.ExecuteNonQuery();

            }






            //if (AddItem.shop.Any())
            //{
            //    Console.WriteLine("give the item id :");
            //    string updt_id = Console.ReadLine();



            //    foreach (var item in AddItem.shop)
            //    {
            //        if (item.getId==updt_id)

            //        {
            //            Console.WriteLine("give the update element \n 1) brand 2)owner 3)price  :");
            //            int ele_num = Convert.ToInt32(Console.ReadLine());

            //            string qry1 = "UPDATE mondayTable SET SAT=@SAT where SAT=@" + updt_id;

            //            if (ele_num==1)
            //            {
            //                Console.WriteLine("give the update brand :");
            //                string u_brand = Console.ReadLine();
            //                item.getBrand = u_brand;
            //                Console.WriteLine("editted the brand");

            //                SqlCommand cmd = new SqlCommand(qry1, conn);
            //                cmd.Parameters.AddWithValue("@" + updt_id, u_brand);
            //                cmd.ExecuteNonQuery();
            //            }


            //            if (ele_num == 2)
            //            {
            //                Console.WriteLine("give the update owner :");
            //                string u_owner = Console.ReadLine();
            //                item.getOwner = u_owner;
            //                Console.WriteLine("editted the owner");
            //            }
            //            if (ele_num == 3)
            //            {
            //                Console.WriteLine("give the update price :");
            //                string u_price = Console.ReadLine();
            //                item.getPrice = u_price;
            //                Console.WriteLine("editted the price");
            //            }


            //        }
            //    }

            //}
            //else 
            //{
            //    Console.WriteLine("there are no items ");
            //}
        }
    }
}
