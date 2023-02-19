using KisiselWebSitesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class AdminControllerController : Controller
    {   
        // GET: AdminController

        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = context.Anasayfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int Id)
        {
            var anaSayGet = context.Anasayfas.Find(Id);
            return View("AnaSayfaGetir", anaSayGet) ;
        }

        public ActionResult AnaSayfaGuncelle(AnaSayfa guncel)
        {
            var AnaSay = context.Anasayfas.Find(guncel.Id);
            AnaSay.Isim = guncel.Isim;
            AnaSay.Profil = guncel.Profil;
            AnaSay.Unvan = guncel.Unvan;
            AnaSay.Aciklama = guncel.Aciklama;
            AnaSay.Iletisim = guncel.Iletisim;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult IkonList()
        {
            var deger = context.Ikonlars.ToList();
            return View(deger);
        }
        [HttpGet] 
        public ActionResult YeniIkon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniIkon(Ikonlar p)
        {
            context.Ikonlars.Add(p);
            context.SaveChanges();
            return RedirectToAction("IkonList");
        }

        public ActionResult IkonGetir(int id)
        {
            var ikonG = context.Ikonlars.Find(id);
            return View("IkonGetir",ikonG);
        }

        public ActionResult IkonGuncelle(Ikonlar x)
        {
            var ig = context.Ikonlars.Find(x.Id);
            ig.Isim = x.Isim;
            ig.Link = x.Link;
            context.SaveChanges();
            return RedirectToAction("IkonList");
        }
        public ActionResult IkonSil(int id)
        {
            var Sil = context.Ikonlars.Find(id);
            context.Ikonlars.Remove(Sil);
            context.SaveChanges();
            return RedirectToAction("IkonList");
        }
    }
}