using Microsoft.EntityFrameworkCore;
using PubReviews.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace PubReviews.Data.Context
{
    public class PubReviewsContext : DbContext
    {
        public PubReviewsContext( DbContextOptions <PubReviewsContext> options) : base(options)
        {
        }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gender> Genders { get; set; }
    }
}
