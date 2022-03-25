using eTrans.Client.Models.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTrans.Client.Services.ServicesTranssport
{
    interface ITransportService
    {
        List<Transport> Transports { get; set; }
        Task LoadTransports();
    }
}
