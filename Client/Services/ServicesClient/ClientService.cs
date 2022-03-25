using eTrans.Client.Models.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace eTrans.Client.Services.ServicesClient
{
    public class ClientService : IClientService
    {
        private readonly HttpClient _http;

        public List<CLient> Clients { get; set; } = new List<CLient>();

        public ClientService(HttpClient http)
        {
            _http = http;
       }
        public async Task LoadClients()
        {
            Clients = await _http.GetFromJsonAsync<List<CLient>>("api/client");
        }
    }
}
