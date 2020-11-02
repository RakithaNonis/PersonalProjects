using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corona.Model
{
    class Symtoms
    {
        public string getSymtomlName { get; set; }
        public int getSymtomlId { get; set; }

        public bool getIsChek { get; set; }

        public Symtoms(int symid, string symnam)
        {
            getSymtomlId = symid;
            getSymtomlName = symnam;


        }
        public Symtoms() { }

       
    }
}
