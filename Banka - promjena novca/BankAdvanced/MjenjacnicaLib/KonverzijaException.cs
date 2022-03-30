﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjenjacnicaLib
{
    public class KonverzijaException : ApplicationException
    {
        public string Poruka { get; set; }

        public KonverzijaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
