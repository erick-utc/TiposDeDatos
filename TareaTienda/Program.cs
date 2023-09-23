using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroCamisas = 0;
            float precioCamisas = 0;
            float porcentajeDescuento = 0;
            float total;
            Console.WriteLine("**** Bienvenido a la Tienda Imaginari ****");
            Console.WriteLine("Digite el numero de camisas que desea adquirir:");
            numeroCamisas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita el monto para cada camisa");
            precioCamisas = float.Parse(Console.ReadLine());
            if(numeroCamisas > 5)
            {
                porcentajeDescuento = 0.2f;
            }else if(numeroCamisas >= 2 )
            {
                porcentajeDescuento = 0.15f;
            }
            total = numeroCamisas * precioCamisas * (1 -porcentajeDescuento);
            Console.Clear();
            Console.WriteLine("   **** Tienda Imaginari ****    ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"El total a cancelar es {total}");
            Console.ReadLine();
        }
    }
}
