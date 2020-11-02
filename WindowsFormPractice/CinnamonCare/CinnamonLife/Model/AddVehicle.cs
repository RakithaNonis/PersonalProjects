using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonLife.Model
{
    class AddVehicle
    {
        public int AddResNumber { get; set; }
        public string  AddBrandName { get; set; }
        public string  AddOwnerName { get; set; }
        public decimal  AddPrice { get; set; }
        public int  AddVehicleId { get; set; }
        public DateTime  AddVehicleDate { get; set; }

        public AddVehicle()
        {
        }
    }
}
