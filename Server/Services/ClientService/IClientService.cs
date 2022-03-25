using eTrans.Client.Models.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTrans.Server.Services.ClientService
{
    public interface IClientService
    {
        Task<List<CLient>> GetClients();
    }
}
