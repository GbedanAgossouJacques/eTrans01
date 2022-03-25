using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTrans.Client.Models.Autos
{
    public class Zem : Auto
    {

        public Zem(MarqueAuto marque, string numeroPlaque, Color coleur) : base(marque, numeroPlaque, coleur)
        {
            Type = TypeAuto.Zem;
            NbrsMaxClient = 2;
        }
       
    }
}
