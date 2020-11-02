using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class DeleteItem
    {
        public static void del_item()
        {
            SqlConnection conn;
            string connString = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connString);
            conn.Open();


            Console.WriteLine("give the user del_ID:");
            int delId =Convert.ToInt32(Console.ReadLine());
                
            for (int i = 0; i < AddItem.shop.Count; i++)
            {
                if (delId == AddItem.shop[i].getUserId)
                {
                    AddItem.shop.RemoveAt(i);

                  
                }
               
            }
            string qry = "DELETE FROM  demo WHERE UserId = '" + delId + "'";
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.ExecuteNonQuery();

            Console.WriteLine("The item has been deleted");
            
        }
        
    }
}
