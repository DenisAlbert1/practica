using Pregunta_1;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_1
{
    public static class Numerosletras
    {
        private static string[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
        private static string[] decenas = { "", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
        private static string[] especiales = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
        public static string Convertir(int numero)
        {
            if (numero < 10)
            {
                return unidades[numero];
            }
            else if (numero < 20)
            {
                return especiales[numero - 10];
            }
            else
            {
                int unidad = numero % 10;
                int decena = numero / 10;
                return decenas[decena] + (unidad > 0 ? " y " + unidades[unidad] : "");
            }
        }
    }



}










    

