using eTrans.Client.Models.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace eTrans.Client.Services.ServicesTranssport
{
    public class TransportService : ITransportService
    {
        private readonly HttpClient _http;
        public List<Transport> Transports { get ; set; }



        public TransportService(HttpClient http)
        {
            _http = http;
        }
        public async Task LoadTransports()
        {
            Transports = await _http.GetFromJsonAsync<List<Transport>>("api/Transport");
        }
    }
}
