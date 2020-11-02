using MVC.Controller;
using MVC.Model;
using MVC.View;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            ControlPerson ctrl = new ControlPerson(per);
            ctrl.MyName = "rakitha";
            ctrl.MyAge = 22;

            PersonShow ps = new PersonShow();
            ps.printPerson(ctrl.MyName,ctrl.MyAge);
            System.Console.ReadLine();

            //Person p = new Person("Isuru",22);
            //console.writeline(p.name+p.age);
        }
    }
}
