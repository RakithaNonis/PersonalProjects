using Microsoft.EntityFrameworkCore;
using PubReviews.Data.Context;
using PubReviews.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubReviews.Data.Services
{
    public class PubService :IPubService
    {
        private readonly PubReviewsContext _context;
        public PubService(PubReviewsContext context)
        {
            _context = context;
        }

        public List<Guest> Get()
        {
            //throw new NotImplementedException();
            return _context.Guests.ToList();
        }
        public List<Guest> FetchAll()
        {
            //throw new NotImplementedException();
            return _context.Guests.ToList();
        }
    }
}
