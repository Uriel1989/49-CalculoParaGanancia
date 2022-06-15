using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoParaGanancia
{
    class Program
    {
        static void Main(string[] args)
        {
            /* El dueño de una tienda compra un artículo a un precio determinado. 
             * Obtener el precio en que lo debe vender para obtener una ganancia del 30%.*/

            PrecioDeVenta PrecioFinal = new PrecioDeVenta();

            Console.WriteLine("Ingrese el precio del articulo adquirido para calcular el precio de venta en estanteria:");
            int PrecioDeVenta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El precio de venta en estanteria para obtener una ganancia del 30% debe ser:");
            Console.WriteLine(PrecioDeVenta + PrecioFinal.PorcentajeAgregado(PrecioDeVenta));

            Console.ReadKey();
        }
    }
}
