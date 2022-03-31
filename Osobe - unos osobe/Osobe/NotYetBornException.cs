using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobe
{
    internal class NotYetBornException : ApplicationException
    {
        public string Poruka { get; set; }
        public NotYetBornException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
