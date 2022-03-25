using eTrans.Client.Models.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTrans.Server.Services.TransportService
{
    public interface ITransportService
    {
        Task<List<Transport>> GetTransports();
    }
}
