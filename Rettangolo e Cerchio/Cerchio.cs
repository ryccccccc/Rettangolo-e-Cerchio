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
        public Cerchio(int r)
        {
            Raggio = r;
        }
        public double Area()
        {
            return Raggio * Raggio * 2 * Math.PI;
        }
        public double Perimetro()
        {
            return Raggio * 2 * Math.PI;
        }

        public override string ToString()
        {
            return string.Format("Cerchio, R = {0}", Raggio);
        }
        public static Cerchio Parse(string cerc)
        {
            string[] raggio = cerc.Split('=');
            Cerchio ct = new Cerchio(int.Parse(raggio[1]));
            return ct;
        }

    }
}
