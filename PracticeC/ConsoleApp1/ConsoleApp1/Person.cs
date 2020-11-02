using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private int age;

        public Person(string Name, int Age)
        {
            this.name = Name;
            this.age = Age;
        }
        public Person() { }
        public int Myage
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Myname
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }


    }
}
