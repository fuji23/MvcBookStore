using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBookStore.Models
{
    public class Shop
    {
        public int ShopID { get; set; }
        public string ShopName { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}