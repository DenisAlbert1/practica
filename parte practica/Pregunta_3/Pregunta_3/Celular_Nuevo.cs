using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_3
{
    class Celular_Nuevo : Celular
    {
        public DateTime FechaIngreso { get; set; }
        public double Precio { get; set; }
        public Celular_Nuevo(string marca, string modelo, string sistemaOperativo, int ram, int almacenamiento, DateTime fechaingreso, double precio) : 
            base(marca, modelo, sistemaOperativo, ram, almacenamiento)
        {
            FechaIngreso = fechaingreso;
            Precio = precio;
        }
        public override void MostrarCelular()
        {
            Console.WriteLine("Marca:" + Marca); 
            Console.WriteLine("Modelo:" + Modelo); 
            Console.WriteLine("sistema opretivo:" + SistemaOperativo); 
            Console.WriteLine("ram: " +RAM +" gb");
            Console.WriteLine("Almacenamiento: " +Almacenamiento+ "GB");
            Console.WriteLine("Fecha de Ingreso:" + FechaIngreso.ToShortDateString());
            Console.WriteLine("Precio:" +Precio+" Bs");
        }
    }
}
