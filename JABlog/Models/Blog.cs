using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JABlog.Models
{
    public class Blog
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Detalle { get; set; }
    }
}