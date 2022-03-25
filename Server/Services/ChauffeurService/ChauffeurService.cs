using eTrans.Client.Models.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTrans.Server.Services.ChauffeurService
{
    public class ChauffeurService : IChauffeurService
    {
        public List<Chauffeur> Chauffeurs { get; set; } = new List<Chauffeur>
            {
        new Chauffeur
        {
            Id = 1,
            Nom = "Jacquesdrive",
            DateDeCreaction = DateTime.Now,
            NumeroDeTelephone = "00062017239"
        },
        new Chauffeur
        {
            Id = 2,
            Nom = "gbedandrive",
            DateDeCreaction = DateTime.Now,
            NumeroDeTelephone = "00090804098"
        },
        new Chauffeur
        {
            Id = 3,
            Nom = "agossoudrive",
            DateDeCreaction = DateTime.Now,
            NumeroDeTelephone = "00061786070"
        },
        new Chauffeur
        {
            Id = 4,
            Nom = "totodrive",
            DateDeCreaction = DateTime.Now,
            NumeroDeTelephone = "00000000000"
        }
            };

        public async Task<List<Chauffeur>> GetAllChauffeur()
        {
            //Chauffeur chauffeur = Chauffeurs.FirstOrDefault(p => p.Id == Id);
            return Chauffeurs;
        }

    }
}
