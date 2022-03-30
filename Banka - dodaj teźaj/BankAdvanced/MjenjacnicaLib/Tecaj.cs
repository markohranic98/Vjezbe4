using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib
{
    public class Tecaj
    {
        private double vrijednost;
        public Valuta Valuta { get; set; }
        public double Vrijednost {
            get
            {
                return this.vrijednost;
            }
            set
            {
                if(value < 0)
                {
                    throw new MjenjacnicaException("Karla");
                }
                else
                {
                    this.vrijednost = value;
                }
                
            }
        }

        public Tecaj(Valuta valuta, double _vrijednost)
        {
            Valuta = valuta;
            this.vrijednost = _vrijednost;
        }
    }
}
