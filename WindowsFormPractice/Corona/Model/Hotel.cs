using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona.Model
{
    class Hotel
    {
        public string getHotelName { get; set; }
        public string getHotelCode { get; set; }

        public Hotel(string hotName, string hotCode)
        {
            getHotelName = hotName;
            getHotelCode = hotCode;
        }
        public Hotel() { }
    }
}
