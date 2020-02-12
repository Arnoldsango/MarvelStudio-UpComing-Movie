using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Data.Entity;


namespace Summer_School_Jan20.Models
{
    public class DatabaseForSummerApp : DbContext
    {
        public DbSet<Movie> movies { get; set; }

    }
}