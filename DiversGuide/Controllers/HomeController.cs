using DGrepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiversGuide.Controllers
{
    public class HomeController : Controller
    {
        //andreas tst
        //dette er en test
        // GET: Home


        Users u = new Users();
        SpotType st = new SpotType();
        Spot s = new Spot();
        SlaebeSteder ss = new SlaebeSteder();
        rating r = new rating();
        Level le = new Level();
        Laws la = new Laws();
        Contact con = new Contact();
        Comments com = new Comments();
        Categori cat = new Categori();
        spotsVM svm = new spotsVM();
        brugerVM bvm = new brugerVM();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kontakt()
        {
            return View();
        }
    }
}