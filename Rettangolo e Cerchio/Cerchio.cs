using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo_e_Cerchio
{
    internal class Cerchio
    {
        public double Raggio { get; set; }
        public double Area()
        {
            return Raggio * Raggio * 2 * Math.PI;
        }
        public double Perimetro()
        {
            return Raggio * 2 * Math.PI;
        }
    }
}
