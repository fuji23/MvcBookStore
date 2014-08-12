using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcBookStore.Models;

namespace MvcBookStore.DAL
{
    public class BSContext : DbContext
    {
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}