using IbeilleMVC.Authentification;
using IbeilleMVC.Models;
using IbeilleMVC.ViewModels;
using lbeille.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IbeilleMVC.Controllers
{
    public class GestionConnexionController : Controller
    {
        Db2014IbeilleEntities context = new Db2014IbeilleEntities();
        //
        // GET: /GestionConnexion/
        public ActionResult Connecter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Connecter(ConnexionVM informationConnexion, string returnUrl)
        {
            ModinMembershipProvider p = new ModinMembershipProvider();

            if (p.ValidateUser(informationConnexion.Pseudo, informationConnexion.Mdp))
            {
                FormsAuthentication.SetAuthCookie(informationConnexion.Pseudo, true);

                HttpCookie cookieUserName =
                    new HttpCookie("username", informationConnexion.Pseudo);
                cookieUserName.Expires = DateTime.Now.AddMonths(12);
                Response.Cookies.Add(cookieUserName);

                return returnUrl == null ? View() : (ActionResult)Redirect(returnUrl);
            }
            else
            {
                ViewBag.Information = "Erreur d'authentification";
                return View("", informationConnexion);
            }
        }

        public ActionResult SEnregistrer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SEnregistrer(lbeille.DAL.Inscrit inscrit, string[] typeInscrit)
        {
            context.Entry(inscrit).State = System.Data.Entity.EntityState.Added;
            context.SaveChanges();


            return RedirectToAction("Connecter");
        }
    }
}