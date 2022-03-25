using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTrans.Client.Models.Visitors;

namespace eTrans.Client.Services.ServicesClient
{
    interface IClientService
    {
        List<CLient> Clients { get; set; }
        Task LoadClients();
    }
}
