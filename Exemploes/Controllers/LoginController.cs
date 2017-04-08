using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exemploes.Models;


namespace Exemploes.Controllers
{
    public class LoginController : Controller
    {
        private VendasEntities db = new VendasEntities();



        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection f, string returnUrl) //Implementando
        {
            string usuario = f["usuario"].ToString();
            if (usuario == "administrador")
            {
                System.Web.Security.FormsAuthentication.SetAuthCookie(usuario, false);
                if (returnUrl == null)
                { return Redirect("/Home/Index"); }
                else
                { return Redirect(returnUrl); }
            }
            else
            {
                System.Web.Security.FormsAuthentication.SignOut();
            }
           
            ViewBag.usuario = usuario;
            return View();
        }
    }
}