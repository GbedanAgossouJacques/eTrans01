using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTrans.Client.Models.Visitors
{
    public class Utilisateur
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "le nom est trop long.")]
        public string Nom { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "le prenom est trop long.")]
        public string Prenoms { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300";
        [Required]
        public string Sex { get; set; }
        [Required]
        public DateTime DateDeNaissance { get; set; }
        public DateTime DateDeCreaction { get; set; }
        [Required]
        public string NumeroDeTelephone { get; set; }

        public Typecompte TypeCompte { get; set; }

        public enum Typecompte
        {
            Client,
            chauffeur
        }
    }
}
