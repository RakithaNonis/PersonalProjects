﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Person p = new Person();
            p.Myage = 40;
            p.Myname = "ds";
            Console.WriteLine(p.Myage+p.Myname);
            Console.ReadLine();
        }
    }
}
