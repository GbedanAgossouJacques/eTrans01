using eTrans.Client.Models.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace eTrans.Client.Services.ServicesChauffeur
{
    public class ChauffeurService : IChauffeurService
    {
        public List<Chauffeur> Chauffeurs { get; set; } = new List<Chauffeur>();

        private readonly HttpClient _http;

        public ChauffeurService(HttpClient http)
        {
            _http = http;
        }
        public async Task LoadChauffeurs()
        {
           Chauffeurs = await _http.GetFromJsonAsync<List<Chauffeur>>("api/chauffeur");
        }

    }
}