using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib
{
    public class Mjenjacnica
    {
        public double PromijeniNovac(string izvorisna, string odredisna, double iznos)
        {
            if(izvorisna == odredisna)
            {
                throw new KonverzijaException("Ana");
            }
            var izvorisnaValuta = MjenjacnicaDB.VratiValutuPoNazivu(izvorisna);
            var odredisnaValuta = MjenjacnicaDB.VratiValutuPoNazivu(odredisna);

            var tecajIzvorisneValute = MjenjacnicaDB.PopisTecajeva.VratiTecajZaValutu(izvorisnaValuta);
            var tecajOdredisneValute = MjenjacnicaDB.PopisTecajeva.VratiTecajZaValutu(odredisnaValuta);

            var omjerTecaja = tecajIzvorisneValute.Vrijednost / tecajOdredisneValute.Vrijednost;

            return omjerTecaja * iznos;
        }
    }
}
