﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaLib.Iznimke
{
    public class ClientException : BankaException
    {
        public ClientException(string poruka) : base(poruka)
        {

        }
    }
}
