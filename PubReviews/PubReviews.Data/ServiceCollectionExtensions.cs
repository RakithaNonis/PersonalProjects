using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PubReviews.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace PubReviews.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDataServices (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PubReviewsContext>(o => o.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //services.AddDbContext<PubReviewsContext>((sp,option)=> option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
