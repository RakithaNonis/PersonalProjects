using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReCourseWork.Model
{
    class Vehicle
    {
        public int getUserId { get; set; }

        public string getBrand { get; set; }
        public string getOwner { get; set; }
        public decimal getPrice { get; set; }
        public int getVehType { get; set; }

        public int getMyId { get; set; }
        public object DefaultView { get; internal set; }

        public string getVehDate { get; set; }

        public string getVehDelDate { get; set; }

        public int getConAdd { get; set; }

        public int getConDel { get; set; }
    }
}
