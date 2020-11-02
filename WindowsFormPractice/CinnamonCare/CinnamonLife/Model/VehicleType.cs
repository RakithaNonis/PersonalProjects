using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonLife.Model
{
    class VehicleType
    {
        public string GetvehicleType { get; set; }
        public int GetvehicleId { get; set; }

        public VehicleType(int vehId,string vehTy) 
        {
            GetvehicleId = vehId;
            GetvehicleType = vehTy;
        }
        public VehicleType() { }
    }
}
