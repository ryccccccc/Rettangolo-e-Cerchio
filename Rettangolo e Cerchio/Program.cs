using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo_e_Cerchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo r = new Rettangolo();
            r.L1 = double.Parse(Console.ReadLine());
            r.L2 = double.Parse(Console.ReadLine()); 
            double areaR = r.Area();
            double perimetroR = r.Perimetro();
            Console.WriteLine(areaR);
            Console.WriteLine(perimetroR);

            Cerchio c = new Cerchio();
            c.Raggio = double.Parse(Console.ReadLine()); ;
            double areaC = c.Area();
            double perimetroC = c.Perimetro();
            Console.WriteLine(areaC);
            Console.WriteLine(perimetroC);

            Console.ReadLine();
        }
    }
}
