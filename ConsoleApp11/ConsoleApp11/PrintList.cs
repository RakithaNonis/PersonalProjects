using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class PrintList
    {
        public static void print_list()
        {
            //string constr;
            //string connString = Properties.Settings.Default.ConStr;
            //SqlConnection conn = new SqlConnection(connString);
            //conn.Open();


            if (AddItem.shop.Any())
            {

                foreach (var item in AddItem.shop.OrderBy(c => c.getBrand))
                {
                    string type_;

                    //if (item.GetType().ToString() == "CourseWork.Car")
                    if (Object.ReferenceEquals(item.GetType(), typeof(Car)))
                    {
                        type_ = "car";

                    }
                    else
                    {
                        type_ = "bike";
                    }
                    Console.WriteLine("id " + item.getUserId + " brand " + item.getBrand + " owner " + item.getOwner +
                        " price " + item.getPrice + " type " + type_);

                    
                }
            }
            else
            {
                Console.WriteLine("there are no items left");
            }
          
        }
    }
}
