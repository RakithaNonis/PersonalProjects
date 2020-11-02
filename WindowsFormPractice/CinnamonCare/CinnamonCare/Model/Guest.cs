using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonCare.Model
{
    class Guest
    {
        public string getPhone { get; set; }
        public string getTable { get; set; }
        public string getName { get; set; }
        public decimal getTemp { get; set; }
        public string getConfirmDate { get; set; }
        public string getConfirTempmDate { get; set; }
        public string getUpDate { get; set; }
        public string getUpTemp { get; set; }
    }
    class Country
    {
        public string getCountryName { get; set; }
        public string getCountryCode { get; set; }

        public Country(string counName, string counCode)
        {
            getCountryName = counName;
            getCountryCode = counCode;
        }
        public Country() { }

    }
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
    class GuestTitle 
    {
        public string getTitlelName { get; set; }
        public int getTitlelCode { get; set; }

        public GuestTitle(string titName, int titCode)
        {
            getTitlelName = titName;
            getTitlelCode = titCode;
        }
        public GuestTitle() { }
    }
    class GuestSymtoms 
    {
        public string getSymtomlName { get; set; }
        public int getSymtomlId { get; set; }

      

        public GuestSymtoms(int symid,string symnam ) 
        {
            getSymtomlId = symid;
            getSymtomlName = symnam;
            

        }
        public GuestSymtoms() { }
    }
    
}
