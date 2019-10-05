using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryApplication.Context
{
    public class LibraryDB : DbContext
    {
        public LibraryDB() : base("name=DBCS")
        {

        }

        public DbSet<Book> Books { get; set; }


    }
}