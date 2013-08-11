using MvcApplication4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcApplication4.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /login/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "ben" && model.Password == "ben")
                {
                    FormsAuthentication.SetAuthCookie(model.Username, true);
                    //if true, user are also in logged in state,although they close their web.
                    return RedirectToAction("Index", "Profile");

                }
                else
                {
                    ModelState.AddModelError("", "Invalid username and password");
                }
            }
            return View();
        }
    }
}
