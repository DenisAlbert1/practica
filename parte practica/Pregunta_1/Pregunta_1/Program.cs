using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese_Numero: ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                string literal = Numerosletras.Convertir(numero);
                Console.WriteLine("forma literal: "+literal);
            }
            else
            {
                Console.WriteLine("Numero invalido");
            }

        }
    }
}

