using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exemplos.Models;


namespace Exemplos.Controllers
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
            if (f["sair"] == "sair")
            {
                System.Web.Security.FormsAuthentication.SignOut();
                return Redirect("/Home/Index");
            }
            string usuario = f["usuario"].ToString();
            string senha = f["senha"].ToString();
            var funcionario = from p in db.tb_fun_funcionario //inicia validação do login 
                              where p.fun_login == usuario
                              select p;
            //if (funcionario.Any())
            if (funcionario.FirstOrDefault() != null)
            {
                if (funcionario.FirstOrDefault().fun_senha.ToString() == senha)
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(usuario, false);
                    if (returnUrl == null)
                    { return Redirect("/Home/Index"); }
                    else
                    { return Redirect(returnUrl); }

                }
                else
                {
                    ViewBag.mensagem = "Senha Incorreta";
                }
              
            }
            else
            {
                ViewBag.mensagem = "Usuario Inexistente";
                System.Web.Security.FormsAuthentication.SignOut();
            }
           
            ViewBag.usuario = usuario;
            return View();
        }

        public ActionResult Sair()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            return Redirect("/Home/Index");
        }
    }
}