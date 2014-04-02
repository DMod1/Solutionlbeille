using IbeilleMVC.Models;
using lbeille.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IbeilleMVC.Controllers
{
    public class GestionEncheresController : Controller
    {
        Db2014IbeilleEntities context = new Db2014IbeilleEntities();
        //
        // GET: /GestionEncheres/
        [Authorize]
        public ActionResult Index()
        {
            return View(context.Encheres.ToList());
        }
	}
}