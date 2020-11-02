using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona.Model
{
    class Dummy
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool isCheck { get; set; }

        public Dummy() { }
        public Dummy(string name , int x)
        {
            Name = name;
            Id = x;
        }
    }
}
