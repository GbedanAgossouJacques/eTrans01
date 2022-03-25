using eTrans.Client.Models.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTrans.Client.Services.ServicesChauffeur
{
    interface IChauffeurService
    {
        public List<Chauffeur> Chauffeurs { get; set; }
        Task LoadChauffeurs();
    }
}
