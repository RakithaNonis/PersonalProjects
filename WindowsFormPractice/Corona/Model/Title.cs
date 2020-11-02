using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona.Model
{
    class Title
    {
        public string getTitlelName { get; set; }
        public int getTitlelCode { get; set; }

        public Title(string titName, int titCode)
        {
            getTitlelName = titName;
            getTitlelCode = titCode;
        }
        public Title() { }
    }
}
