using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NextConsole
{
    class PrintList
    {

        public static void print_list()
        {


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
                    Console.WriteLine("id " + item.getId + " brand " + item.getBrand + " owner " + item.getOwner + " price " + item.getPrice + " type " + type_);


                }
            }
            else
            {
                Console.WriteLine("there are no items left");
            }
        }
    }
}
