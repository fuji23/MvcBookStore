using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBookStore.Models
{
    public class Book 
    {
        public Book()
        {
        }
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int Sale { get; set; }
    }
}