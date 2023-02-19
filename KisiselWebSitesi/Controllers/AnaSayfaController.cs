using KisiselWebSitesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa

        Context context = new Context();
        
        public ActionResult Index()
        {
            var deger = context.Anasayfas.ToList();
            return View(deger); 
        }

        public PartialViewResult ikonlar()
        {
            var deger = context.Ikonlars.ToList();
            return PartialView(deger);
        }
    }
}