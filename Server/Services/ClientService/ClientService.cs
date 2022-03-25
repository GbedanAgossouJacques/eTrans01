using eTrans.Client.Models.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTrans.Server.Services.ClientService
{
    public class ClientService : IClientService
    {
        public List<CLient> Clients { get; set; } = new List<CLient>
            {
        new CLient
        {
            Id = 1,
            Nom = "Jacques et melchior",
            Image = "Images/mel.jpg",
            DateDeCreaction = DateTime.Now,
            NumeroDeTelephone = "62017239"
        },
        new CLient
        {
            Id = 2,
            Nom = "Moftoura",
            Image = "Images/mof.jpg",
            DateDeCreaction = DateTime.Now,
            NumeroDeTelephone = "90804098"
        },
        new CLient
        {
            Id = 3,
            Nom = "Kifayath",
            Image = "Images/kif.jpg",
            DateDeCreaction = DateTime.Now,
            NumeroDeTelephone = "61786070"
        },
        new CLient
        {
            Id = 4,
            Nom = "Mirabelle",
            Image = "Images/mira.jpg",
            DateDeCreaction = DateTime.Now,
            NumeroDeTelephone = "00000000"
        }
            };

        public async Task<List<CLient>> GetClients()
        {
            //await Task.Delay(1000);
            return Clients;
        }
    }
}
