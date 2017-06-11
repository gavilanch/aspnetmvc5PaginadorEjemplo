using PaginadorMVC5.Models;
using PaginadorMVC5.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PaginadorMVC5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? edad, int pagina = 1)
        {
            var cantidadRegistrosPorPagina = 5; // parámetro
            using (var db = new ApplicationDbContext())
            {
                Func<Persona, bool> predicado = x => !edad.HasValue || edad.Value == x.Edad;

                var personas = db.Personas.Where(predicado).OrderBy(x => x.Id)
                    .Skip((pagina - 1) * cantidadRegistrosPorPagina)
                    .Take(cantidadRegistrosPorPagina).ToList();
                var totalDeRegistros = db.Personas.Where(predicado).Count();

                var modelo = new IndexViewModel();
                modelo.Personas = personas;
                modelo.PaginaActual = pagina;
                modelo.TotalDeRegistros = totalDeRegistros;
                modelo.RegistrosPorPagina = cantidadRegistrosPorPagina;
                modelo.ValoresQueryString = new RouteValueDictionary();
                modelo.ValoresQueryString["edad"] = edad;

                return View(modelo);
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}