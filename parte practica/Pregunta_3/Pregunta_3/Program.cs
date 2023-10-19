using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular_Nuevo celularNuevo = new Celular_Nuevo("SAMSUNG ", " A21 ", " Android ", 6 , 64 , DateTime.Now, 1200);
            Celular_Defectuoso celularDefectuoso = new Celular_Defectuoso("SAMSUNG", "A11", "Android", 4, 32, DateTime.Now, "Bateria defectuosa");
            Console.WriteLine("Informacion del Celular Nuevo:");
            celularNuevo.MostrarCelular();
            Console.WriteLine("\n");
            Console.WriteLine("Informacion del Celular Defectuoso:");
            celularDefectuoso.MostrarCelular();
            Console.ReadKey();
        }
    }
}
