using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTrans.Client.Models.Autos
{
    public class Auto
    {
        public string PlaqueNumero { get; set; }
        public int Id { get; set; }
        public int NbrsMaxClient { get; set; } = 4;
        public bool IsChangePlaque { get; set; }
        public MarqueAuto Marque { get; set; }
        public TypeAuto Type { get; set; }
        private Color _color { get; set; }

        public Auto(MarqueAuto marque, string numeroPlaque, Color coleur)
        {
            Marque = marque;
            PlaqueNumero = numeroPlaque;
            _color = coleur;

               
        }
        public bool ChangerPlaque(string plaque = null)
        {
            if (plaque == null)
            {
                IsChangePlaque = false;
            }
            else
            {
                PlaqueNumero = plaque;
                IsChangePlaque=true;
            }

            return IsChangePlaque;
        }
        public enum Color
        {
            Rouge,
            Verte,
            Bleu,
            Jaune,
            Cendre,
            Orange,
            Noire,
            Blanche
        }
        public enum TypeAuto
        {
            Zem,
            Tricycle,
            Taxi
        }
        public enum MarqueAuto
        {
            Haojue_110,
            Wave_110,
            Sanili,
            Dayang,
            Dream,
            Yamaha,
            Bajag
        }
  
    }
}
