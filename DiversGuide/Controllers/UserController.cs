using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DGrepo;

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
    }
}