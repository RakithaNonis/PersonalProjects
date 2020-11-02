using MVCProject1.Controller;
using MVCProject1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read Inputs from

            Vehicle v = new Vehicle();
            //v.ID = 


            bool responce = VehicleController.Insert(v);

            if (responce)
            {
                Console.WriteLine("Saved succe...");
            }


        }
    }
}
