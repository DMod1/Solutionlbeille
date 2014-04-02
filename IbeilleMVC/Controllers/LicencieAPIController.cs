using IbeilleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IbeilleMVC.Controllers
{
    public class LicencieAPIController : ApiController
    {
        static List<Licencie> lesLicencies = new List<Licencie> {
                new Licencie { NumeroLicence = 118, Nom = "Ibrahimovic", Prenom = "Zlatan", DateNaissance = new DateTime(1981, 10, 3), NombreButs = 11 },
                new Licencie { NumeroLicence = 119, Nom = "Gameiro", Prenom = "Kevin", DateNaissance = new DateTime(1987, 5, 9), NombreButs = 3 },
                new Licencie { NumeroLicence = 107, Nom = "Menez", Prenom = "Jérémy", DateNaissance = new DateTime(1987, 5, 7), NombreButs = 5 }
            };
        public LicencieAPIController()
        {

        }
        // GET api/<controller>
        public IEnumerable<Licencie> Get()
        {
            return lesLicencies;
        }

        // GET api/<controller>/5
        public Licencie Get(int id)
        {
            return lesLicencies.Where(x => x.NumeroLicence == id).First();
        }


        [HttpPost]
        // POST api/<controller>
        public HttpResponseMessage Post(Licencie unLicencie)
        {
            unLicencie.NumeroLicence = lesLicencies.Max(x => x.NumeroLicence) + 1;
            lesLicencies.Add(unLicencie);
            return Request.CreateResponse(HttpStatusCode.Created, unLicencie);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public HttpResponseMessage Delete(int id)
        {
            Licencie licencieASupprimer =
                lesLicencies.Where(x => x.NumeroLicence == id).First();
            lesLicencies.Remove(licencieASupprimer);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpDelete]
        public HttpResponseMessage DeleteLicencie(int numeroLicencie)
        {
            Licencie licencieASupprimer =
                lesLicencies.Where(x => x.NumeroLicence == numeroLicencie).First();
            lesLicencies.Remove(licencieASupprimer);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}