using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("name please :");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("age please :");
            string age = Console.ReadLine();
            int Age = Convert.ToInt32(age);
            Console.WriteLine(age);
        }
    }
}
