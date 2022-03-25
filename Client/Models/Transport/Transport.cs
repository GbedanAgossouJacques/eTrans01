using eTrans.Client.Models.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTrans.Client.Models.Transport
{
    public class Transport
    {
        public int? Id { get; set; }
        public Chauffeur Chauffeur { get; set; } = new Chauffeur();
        public CLient Client { get; set; } = new CLient();
        public bool IsReservation { get; set; } = true;
        public decimal Distance { get; set; }
        public decimal Prix { get; set; }
        public DateTime Datecommande { get; set; } = DateTime.Now;
        public Point Depart;
        public Point Arrivee;

        public struct Point
        {
            DateTime Date { get; set; }
            string Lieu { get; set; }

        }
    }
}
