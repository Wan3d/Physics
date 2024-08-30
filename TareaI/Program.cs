using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;



namespace TareaI

{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numeroFuerzas = 0, contadorFuerzas = 0, cont = 1;
            double anguloGrados = 0, fuerzasX = 0, fuerzasY = 0, anguloRadianes = 0, sumaFuerzasX = 0, sumaFuerzasY = 0, anguloFinal = 0;
            double r = 0, cuadradoSumaFuerzasX = 0, cuadradoSumaFuerzasY = 0, fuerzasTotales = 0;
            Console.Write("Introduce el número de las fuerzas: \n");
            numeroFuerzas = int.Parse(Console.ReadLine());
            while (contadorFuerzas < numeroFuerzas)
            {
                Console.Write("Ingresa la fuerza [" + cont + "] = ");
                fuerzasTotales = double.Parse(Console.ReadLine());
                Console.Write("Ingresa el ángulo (en grados) de la fuerza [" + cont + "] = ");
                anguloGrados = double.Parse(Console.ReadLine());
                anguloRadianes = anguloGrados * (Math.PI / 180);                //Convertir a radianes
                fuerzasX = fuerzasTotales * Math.Cos(anguloRadianes);
                sumaFuerzasX += fuerzasX;                        //Suma fuerzas X
                fuerzasY = fuerzasTotales * Math.Sin(anguloRadianes);
                sumaFuerzasY += fuerzasY;                      //Suma fuerzas Y
                cont++;
                contadorFuerzas++;
            }
            cuadradoSumaFuerzasX = sumaFuerzasX * sumaFuerzasX;
            cuadradoSumaFuerzasY = sumaFuerzasY * sumaFuerzasY;
            r = Math.Sqrt(cuadradoSumaFuerzasX + cuadradoSumaFuerzasY);
            anguloFinal = Math.Atan(sumaFuerzasY / sumaFuerzasX);
            double anguloFinalGrados = anguloFinal * (180 / Math.PI);            //Convertir de radianes a grados el ángulo final

            if (sumaFuerzasX > 0 && sumaFuerzasY > 0)
            {
            Console.WriteLine("a");
            }
            else if (sumaFuerzasX < 0 && sumaFuerzasY > 0)
            {
                Console.WriteLine("b");
                anguloFinalGrados = anguloFinalGrados + 180;
            }
            else if (sumaFuerzasX < 0 && sumaFuerzasY < 0)
            {
                Console.WriteLine("c");
                anguloFinalGrados = anguloFinalGrados + 180;
            }
            else if (sumaFuerzasX > 0 && sumaFuerzasY < 0)
            {
                Console.WriteLine("d");
                anguloFinalGrados = anguloFinalGrados + 360;
            }
            Console.WriteLine("\nSuma total de las fuerzas en X = " + sumaFuerzasX);
            Console.WriteLine("\nSuma total de las fuerzas en Y = " + sumaFuerzasY);
            Console.WriteLine("\nR = " + r);
            Console.WriteLine("\nÁngulo final = " + anguloFinalGrados + "\n");
        }
    }
}