using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class TriangleException : Exception
    {
        public string Message { get; set; }
        public TriangleException(string message)
        {
            Message = message;
        }
    }
}
