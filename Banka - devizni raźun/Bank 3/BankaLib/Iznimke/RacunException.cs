﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib.Iznimke
{
    public class RacunException : BankaException
    {
        public RacunException(string poruka) : base(poruka)
        {
        }
    }
}
