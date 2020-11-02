using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Vehicle
    {
        public string getBrand { get; set; }
        public string getOwner { get; set; }
        public decimal getPrice { get; set; }

        public int getUserId { get; set; }
    }
}
//INSERT INTO table_name(column1, column2, column3, ...)
//VALUES(value1, value2, value3, ...);

//INSERT INTO demo(Id, Brand, Owner, Price)VALUES('hh', 'hh', 'hh', 'hh');