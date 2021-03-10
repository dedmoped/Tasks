using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestTask.Models
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb() : base("ShopsContext")
        {

        }

        public DbSet<Magazines> Magazines { get; set; }
        public DbSet<Products> Products { get; set; }

    }
}