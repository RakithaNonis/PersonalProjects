using System;
using System.Collections.Generic;
using System.Text;

namespace OOPusage
{
    class Person
    {
        private string name;

        public Person(string name_)
        {
            this.name = name_;
        }
        public Person() { }


        public string Name
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
