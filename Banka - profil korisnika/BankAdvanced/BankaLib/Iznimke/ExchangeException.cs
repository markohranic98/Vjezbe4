using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib.Iznimke
{
    internal class ExchangeException : BankaException
    {
        public ExchangeException(string poruka) : base(poruka)
        {

        }
    }
}
