using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    internal class BannedNameException : ApplicationException
    {
        public string Poruka { get; set; }

        public BannedNameException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
