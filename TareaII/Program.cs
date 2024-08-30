using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace TareaII
{
    public class Program
    {
        public enum Fuerzas
        {
            FAc,
            FBc,
            FCc
        }

        public static void Main(string[] args)
        {
            double[] angulo = new double[3];
            double[] anguloRadianes = new double[3];
            double[] anguloXGrados = new double[3];
            double[] anguloYGrados = new double[3];
            double detFAc = 0, detFBc = 0, det = 0, det2 = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el ángulo (en grados) de la fuerza " + (Fuerzas)i + "= ");
                angulo[i] = double.Parse(Console.ReadLine());
                anguloRadianes[i] = angulo[i] * (Math.PI / 180);
                anguloXGrados[i] = Math.Cos(anguloRadianes[i]);
                anguloYGrados[i] = Math.Sin(anguloRadianes[i]);
            }
            Console.Write("Introduce la fuerza " + (Fuerzas)2 + "= ");
            double fuerzaFCc = double.Parse(Console.ReadLine());
            anguloXGrados[2] = fuerzaFCc * anguloXGrados[2];
            anguloYGrados[2] = fuerzaFCc * anguloYGrados[2];
                if (anguloXGrados[2] != 0)
            {
                anguloXGrados[2] = -anguloXGrados[2];
            }
            if (anguloYGrados[2] != 0)
            {
                anguloYGrados[2] =  -anguloYGrados[2];
            }
        
            Console.WriteLine("\nEcuaciones: ");
            Console.WriteLine("\n(" + anguloXGrados[0] + "FAc) + (" + anguloXGrados[1] + "FBc) = " + anguloXGrados[2]);
            Console.WriteLine("\n(" + anguloYGrados[0] + "FAc) + (" + anguloYGrados[1] + "FBc) = " + anguloYGrados[2]);
            detFAc = ((anguloXGrados[2] * anguloYGrados[1]) - (anguloYGrados[2] * anguloXGrados[1]));
            det = ((anguloXGrados[0] * anguloYGrados[1]) - (anguloYGrados[0] * anguloXGrados[1]));
            detFBc = ((anguloXGrados[0] * anguloYGrados[2]) - (anguloYGrados[0] * anguloXGrados[2]));
            det2 = ((anguloXGrados[0] * anguloYGrados[1]) - (anguloYGrados[0] * anguloXGrados[1]));
            Console.WriteLine("\nFAc = " + detFAc / det);
            Console.Write("\nFBc " + detFBc / det2);
        }
    }
}