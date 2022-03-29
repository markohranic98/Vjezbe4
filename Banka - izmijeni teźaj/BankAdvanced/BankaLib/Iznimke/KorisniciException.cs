using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankaLib.Iznimke;
namespace BankaLib.Iznimke
{
    public class KorisniciException : BankaException
    {
        public KorisniciException(string poruka) : base(poruka)
        {

        }
    }
}
