using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPrecioProducto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadProductos;
            int precioProductos = 20;
            int total;

            Console.WriteLine("Ingrese la cantidad de productos que desea comprar");
            cantidadProductos = int.Parse(Console.ReadLine());
            if( cantidadProductos > 10 )
            {
                precioProductos = 15;
            }
            total = cantidadProductos * precioProductos;
            Console.WriteLine($"El precio por producto es: ${precioProductos}");
            Console.WriteLine($"El total a cancelar es: ${total}");
            Console.ReadLine();
        }
    }
}
