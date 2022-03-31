using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib
{
    public class DevizniRacun : Racun
    {
        public override string Opis => $"IBAN:{IBAN}, Stanje:{Stanje}, Valuta:{Valuta.Oznaka}";

        public DevizniRacun(string iban, double stanje, Valuta valuta, IKlijent klijent) : base(iban, stanje, klijent)
        {
            if(valuta.Oznaka == "HRK")
            {
                throw new Iznimke.RacunException("ne moze hrk");
            }
            Valuta = valuta;
            Tip = TipRacuna.Devizni;
        }
    }
}
