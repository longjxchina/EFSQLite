using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFSQLite.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext()
            :base("name=SQLiteDB")
        { }

        public DbSet<Movie> Movies { get; set; }
    }
}