using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila_Forms_DllRef
{
    internal class NoNameException : ApplicationException
    {
        public string Poruka { get; set; }

        public NoNameException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
