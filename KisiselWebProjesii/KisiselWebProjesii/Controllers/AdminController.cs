using KisiselWebProjesii.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebProjesii.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int id)
        {
            var ag = c.AnaSayfas.Find(id);
            return View("AnaSayfaGetir", ag);
        }

        public ActionResult AnaSayfaGüncelle(AnaSayfa x)
        {
            var ag = c.AnaSayfas.Find(x.id);
            ag.isim = x.isim;
            ag.profile = x.profile;
            ag.job = x.job;
            ag.description=x.description;
            ag.communication = x.communication ;
            
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult ikonListesi()
        {
            var deger = c.ikonlars.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult YeniIkon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniIkon(ikonlar p)
        {
            if (ModelState.IsValid)
            {
                c.ikonlars.Add(p);
                c.SaveChanges();
                return RedirectToAction("ikonListesi");
            }
            return View(p); 
        }

        public ActionResult ikonGetir(int id)
        {
            var ig = c.ikonlars.Find(id);
            return View("ikonGetir", ig);

        }

        public ActionResult ikonGuncelle(ikonlar x)
        {
            var ig = c.ikonlars.Find(x.id);
            ig.ikon = x.ikon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("ikonListesi");

        }

        public ActionResult ikonSil(int id)
        {
            var sl = c.ikonlars.Find(id);
            c.ikonlars.Remove(sl);
            c.SaveChanges();
            return RedirectToAction("ikonListesi");

        }

    }
}