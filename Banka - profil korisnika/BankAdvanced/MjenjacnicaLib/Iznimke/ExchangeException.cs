using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib.Iznimke
{
    public class ExchangeException : Exception
    {
        public string Poruka { get; set; }

        public ExchangeException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
