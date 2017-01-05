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
        Spots s = new Spots();
        SlaebeSteder ss = new SlaebeSteder();
        rating r = new rating();
        Level le = new Level();
        Laws la = new Laws();
        Contact con = new Contact();
        Comments com = new Comments();
        Categori cat = new Categori();
        spotsVM svm = new spotsVM();
        brugerVM bvm = new brugerVM();
        SpotsFac sf = new SpotsFac();
        RatingFac rf = new RatingFac();
        SpotsFac ssf = new SpotsFac();
        public ActionResult Index()
        {
            svm.spots = ssf.GetAll();
            svm.rating = rf.GetAll();

            return View(svm);
        }

        public ActionResult Kontakt()
        {
            return View();
        }
    }
}