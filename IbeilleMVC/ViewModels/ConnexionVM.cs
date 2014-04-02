using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IbeilleMVC.ViewModels
{
    public class ConnexionVM
    {
        [Required]
        [Display(Name="Nom d'utilisateur")]
        public string Pseudo { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Mot de passe")]
        public string Mdp { get; set; }
    }
}