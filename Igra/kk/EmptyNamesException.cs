using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kk
{
    internal class EmptyNamesException : ApplicationException
    {
        public string Poruka { get; set; }

        public EmptyNamesException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
