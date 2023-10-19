using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    class Celular_Defectuoso : Celular
    {
        DateTime Fecha_Detecto;
        string Motivo;
        public Celular_Defectuoso(string marca, string modelo, string sistemaOperativo, int ram, int almacenamiento,DateTime fechadetecto,string motivo) 
            : base(marca, modelo, sistemaOperativo, ram, almacenamiento)
        {
            Fecha_Detecto = fechadetecto;
            Motivo = motivo;    
        }
        public override void MostrarCelular()
        {
            Console.WriteLine("Marca:" + Marca);
            Console.WriteLine("Modelo:" + Modelo);
            Console.WriteLine("sistema opretivo:" + SistemaOperativo);
            Console.WriteLine("ram: " + RAM + " gb");
            Console.WriteLine("Almacenamiento: " + Almacenamiento + "GB");
            Console.WriteLine("Fecha de Detecto:" + Fecha_Detecto.ToShortDateString());
            Console.WriteLine("Motivo:" + Motivo );
            
        }
    }
}
