using MVC.Model;
using MVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controller
{
    class ControlPerson
    {
        private Person model;
      

        //public ControlPerson(Person model, PersonShow view)
        //{
        //    this.model = model;
        //    this.view = view;
        //}
        public ControlPerson(Person model)
        {
            this.model = model;
            
        }
        public string MyName {
            get 
            {
                return model.Name;
            }
            set 
            {
                model.Name = value;
            } }
        public int MyAge
        {
            get
            {
                return model.Age;
            }
            set
            {
                model.Age = value;
            }
        }
    }
}
