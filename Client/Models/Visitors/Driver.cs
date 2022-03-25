using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTrans.Client.Models.Autos;

namespace eTrans.Client.Models.Visitors
{
    public class Chauffeur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenoms { get; set; }
        public string Image { get; set; } = "https://via.placeholder.com/300";
        public string Description { get; set; } = "je suis un chauffeur aimable et calme";
        public DateTime DateDeNaissance { get; set; }
        public DateTime DateDeCreaction { get; set; }
        public string NumeroDeTelephone { get; set; }
        public bool EstEligible { get; set; } = false;

        public Auto Automobile = new Zem(Auto.MarqueAuto.Bajag, "1235bh", Auto.Color.Rouge);
        public string Sex { get; set; }
        public string CityOfOriigin { get; set; }
        public string CurrentCity { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TElNumero { get; set; }
        public bool IsSubscribe { get; set; } = false;
        public override string ToString()
        {
            return string.Format("Nom : {0};\n Prenom : {1};\n Sexe : {2};\n Date de naissance : {3};\n Numero de telephone : {4}; \n Numero de plaque  : {5} ", Nom, Prenoms, Sex, DateOfBirth, TElNumero, Automobile.PlaqueNumero);
        }
    }
}
