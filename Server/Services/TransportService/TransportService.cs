using eTrans.Client.Models.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTrans.Server.Services.TransportService
{
    public class TransportService : ITransportService
    {
        public List<Transport> Transports { get; set; } = new List<Transport>
            {
        new Transport
        {
            Id = 1,
            IsReservation = true,
            Distance = 15.2M,
            Datecommande = DateTime.Now,
            Prix = 300
        },
        new Transport
        {
            Id = 2,
            IsReservation = true,
            Distance = 6.2M,
            Datecommande = DateTime.Now,
            Prix = 200
        },
        new Transport
        {
            Id = 3,
            IsReservation = false,
            Distance = 1.2M,
            Datecommande = DateTime.Now,
            Prix = 100
        },
        new Transport
        {
            Id = 4,
            IsReservation = false,
            Distance = 10,
            Datecommande = DateTime.Now,
            Prix = 500
        }
            };

        public async Task<List<Transport>> GetTransports()
        {
            //await Task.Delay(1000);
            return Transports;
        }
    }
}
