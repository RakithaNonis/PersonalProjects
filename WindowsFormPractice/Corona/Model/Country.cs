using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona.Model
{
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
}
