using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IbeilleMVC.Models
{
    public class Licencie
    {
        public int NumeroLicence { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public int NombreButs { get; set; }
    }
}