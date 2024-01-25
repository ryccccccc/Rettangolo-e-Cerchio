using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo_e_Cerchio
{
    internal class Rettangolo
    {
        public double L1 { get; set; }
        public double L2 { get; set; }
        public double Area()
        {
            return L1 * L2;
        }
        public double Perimetro()
        {
            return 2 * (L1 + L2);
        }
    }
}
