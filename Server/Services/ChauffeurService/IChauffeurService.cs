using eTrans.Client.Models.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTrans.Server.Services.ChauffeurService
{
    public interface IChauffeurService
    {
        public List<Chauffeur> Chauffeurs { get; set; }
        Task<List<Chauffeur>> GetAllChauffeur();
    }
}
