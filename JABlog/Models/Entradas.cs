using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JABlog.Models
{
    public class Entradas
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime Fecha { get; set; }
    }
}