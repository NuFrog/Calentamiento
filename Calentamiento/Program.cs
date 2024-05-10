using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calentamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcula el área de un rectángulo
            double ladoA, ladoB, resultado;
            Console.WriteLine("Calcula el area de un rectangulo");
            Console.Write("Ingrese el valor del lado A: ");

            ladoA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el valor del lado B: ");
            ladoB = Convert.ToDouble(Console.ReadLine());

            resultado = ladoA * ladoB;

            Console.WriteLine("El área del rectángulo es: " + resultado);
            Console.ReadKey();
        }
    }
}
