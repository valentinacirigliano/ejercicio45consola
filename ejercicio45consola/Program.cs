using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio45consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SUMA DE LOS PRIMEROS 5 NÚMEROS";
            int  numeroIngresado, suma=0;
            for (int contador = 1; contador < 6; contador++)
            {
                Console.Write($"Ingrese el {contador}° número: ");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
                suma += numeroIngresado;
            }
            Console.WriteLine($"Valor final de la suma:  {suma}");
            Console.ReadLine();
        }
    }
}
