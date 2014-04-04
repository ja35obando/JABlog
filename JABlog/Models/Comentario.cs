using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JABlog.Models
{
    public class Comentario
    {
        public int id { get; set; }
        public int IdUsuario { get; set; }
        public int IdNoticia { get; set; }
        public string Comentarios { get; set; }
    }
}