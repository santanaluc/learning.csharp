using System;
using System.Collections.Generic;
using System.Text;

namespace TipoReferencia
{
    struct Point
    {
        public double X, Y;
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}
