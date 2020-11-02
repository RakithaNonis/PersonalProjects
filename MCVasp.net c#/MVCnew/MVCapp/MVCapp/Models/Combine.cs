using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCapp.Models
{
    public class Combine
    {
        public Movie movie { get; set; }

        //  public Customer customer { get; set; }
        public List<Customer> customer { get; set; }
    }
}