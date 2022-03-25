using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTrans.Client.Models.Autos
{
    internal class Taxi : Auto
    {
        public Taxi(MarqueAuto marque, string numeroPlaque, Color coleur) : base(marque, numeroPlaque, coleur)
        {
        }
    }
}
