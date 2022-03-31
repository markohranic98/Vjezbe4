using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankarstvoLib
{
    public class Uplata : Transakcija
    {
        public Uplata(Racun racun, string ibanProturacuna, double iznos) : base(racun, ibanProturacuna, iznos)
        {
            Vrsta = VrstaTransakcije.Uplata;
        }


        public override void Provedi()
        {
            Racun.Stanje += Iznos;
            Datum = DateTime.Now;
        }
    }
}
