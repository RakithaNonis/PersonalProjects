using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            // return View();
            return Content("This is the INdex action");
        }
        //public ActionResult Test() 
        // {
        //     //  return View();
        //     return Content("This is the Test action" );
        // }
        public ActionResult Test()
        {
            var obj = new Movie()
            {
                Id = 1,
                Name = "Die hard"
            };
            var cusobj = new List<Customer>
           {
                new Customer{ Id=10 , Name="Rakitha"},
                new Customer { Id=11 , Name="Chehan"},
                new Customer { Id=12 , Name="Nonis"}
           };

            var total = new Combine()
            {
                movie = obj,
                customer = cusobj
            };
              return View(total);
            //return Content("This is the Test action");
        }

    }
}