using IbeilleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace IbeilleMVC.Controllers
{
	public class LicencieController : Controller
	{
		//
		// GET: /Licencie/
		public ActionResult Index()
		{
			return View();
		}

        //[HttpPost]
        //public HttpResponseMessage PostNewLicencie(Licencie unLicencie)
        //{
        //    //unLicencie.Num
        //}
	}
}