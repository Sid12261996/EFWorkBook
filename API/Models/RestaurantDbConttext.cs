using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class RestaurantDbConttext:DbContext
    {
      public DbSet<Restaurant> Restaurants { get; set; }
       

    }
}