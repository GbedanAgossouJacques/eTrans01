using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTrans.Client.Models.Visitors
{
    public class CLient
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
        public string Description { get; set; } = "Je vais donner le meilleur de moi meme tout au long de cette semaine";
        [Required]
        public string Sex { get; set; }
        [Required]
        public DateTime DateDeNaissance { get; set; }
        [Required]
        public DateTime DateDeCreaction { get; set; }
        [Required]
        public string NumeroDeTelephone { get; set; }
        public bool EstAbonnee { get; set; } = false;
        
        public string CityOfOriigin { get; set; }
        public string CurrentCity { get; set; }
        public bool IsSubscribe { get; set; } = false;
        public override string ToString()
        {
            return string.Format(" Nom : {0};\n Prenoms : {4};\n Sexe : {1};\n Date de naissance : {2};\n Numero de telephone: {3}", Nom, Sex, DateDeNaissance, NumeroDeTelephone, Prenoms); 
        }

    }
}
