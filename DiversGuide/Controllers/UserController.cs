using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DGrepo;
using System.Web.Helpers;
using System.Web.Security;

namespace DiversGuide.Controllers
{
    
    public class UserController : Controller
    {
        UsersFac uf = new UsersFac();
        // GET: User
        public ActionResult user()
        {
            return View();
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Users User)
        {
            if (!uf.UserExist(User.Email))
            {
                if (!uf.UserExist(User.Name))
                {
                    if (ModelState.IsValid)
                    {
                        uf.Update(User);
                    }

                }
                else
                {
                    ViewBag.MSG = "Navnet er allerede i brug";
                }
            }
            else
            {
                ViewBag.MSG = "emailen er allerede i  brug, prøv en anden!!";
            }

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string adgangskode)
        {
            Users bruger = uf.Login(email.Trim(), Crypto.Hash(adgangskode.Trim()));

            if (bruger.ID > 0)
            {
                FormsAuthentication.SetAuthCookie(bruger.ID.ToString(), false);
                Response.Redirect("/Admin/ABruger/Edit/");
            }

            return Redirect("/Admin/ABruger/Edit");
        }
        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();

            return View("Index");
        }
        public ActionResult Opret()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Opret(Users user, string gentag) //vi henter dataen fra vores model Bruger, og vi henter den nye data fra formen punkt ,gentag
        {
            if (!uf.UserExist(user.Email)) //vi siger, hvis brugern ikke(!) ikksister ser på emailen så gør det inde i if
            {
                if (user.Password == gentag) //hvis emailen ikke ikksistere så kig på adgangskoderne, hvis gentag er de samme som (==) Adgangskode så gør det næste
                {
                    user.Transfer = "Default"; //vi sætter dataen til default

                    if (ModelState.IsValid) //vi tjekker om vores model har alle felter udfyldte
                    {
                        user.Password = Crypto.Hash(user.Password); //vi cryptere vores adgangskode
                        uf.Insert(user); //vi sætter vores instands af bf  sammen med bruger

                        ViewBag.MSG = "Brugern er nu oprettet!!!"; //vi fortæller brugern at han er blevet oprettet
                    }
                }
                else
                {
                    ViewBag.MSG = "De to Adgangskoder skal være ens!!"; //hvis gentag og adgangskoden ikke matched fortæl brugern at der er fejl der
                }
            }
            else
            {
                ViewBag.MSG = "emailen er allerede i  brug, prøv en anden!!"; //hvis emailen allerede ikksistere fortæl brugern det 
            }
            return View();
        }
    }
}