using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studenti
{
    class Student
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Student(string ime, string prezime)
        {
            if(ime == "Branko")
            {
                throw new BannedNameException("Ne smije se zvat branko");
            }
            Ime = ime;
            Prezime = prezime;
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
