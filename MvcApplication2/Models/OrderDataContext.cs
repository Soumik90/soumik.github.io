using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class OrderDataContext:DbContext
    {
        public DbSet<Order> Order { get; set; }
        public OrderDataContext(): base("DefaultConnection")
        {

        }
    }
}