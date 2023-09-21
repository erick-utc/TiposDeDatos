using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           


            Console.WriteLine("Digite su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el monto");
            float monto = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los meses");
            float meses = float.Parse(Console.ReadLine());
            float cuota = monto / meses;
            float total = cuota * 1.05f;
            Console.WriteLine($"Por mes debe pagar {cuota}");



        }
    }
}
