using JABlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JABlog.Controllers
{
    public class HomeController : Controller
    {
        private JABlogDbContext db = new JABlogDbContext();

        public ActionResult Index()
        {
            ViewBag.Message = "Entradas";
            return View(db.Entradas.ToList());
        }

        public ActionResult About(int id = 0)
        {
            Blog blog = db.Blogs.Find(2);
            Blogger blog1 = db.Blogers.Find(1);
            if (blog == null)
            {
                return HttpNotFound();
            }
            ViewBag.Me = blog1.Name;
            ViewBag.Bio = blog1.Bio;
            return View(blog);
        }

        public ActionResult Comment(int id = 0)
        {
            Entradas entradas = db.Entradas.Find(id);
            //Comentario comentario = db.Comentarios.Find(id);
            if (entradas == null)
            {
                return HttpNotFound();
            }
            ViewBag.id = entradas.id;
            ViewBag.Titulo = entradas.Titulo;
            ViewBag.contenido = entradas.Contenido;
            ViewBag.fecha = entradas.Fecha;
            return View();
        }

        public ActionResult Administrador()
        {
            return View();
        }
    }
}
