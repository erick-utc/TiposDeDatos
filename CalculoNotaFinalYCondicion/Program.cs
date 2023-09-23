using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoNotaFinalYCondicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idCarnet;
            string nombre;
            string condicion;
            float quiz1;
            float quiz2;
            float quiz3;
            float tarea1;
            float tarea2;
            float tarea3;
            float examen1;
            float examen2;
            float examen3;
            float porcentajeQuices;
            float porcentajeTareas;
            float porcentajeExamen;
            float promedioFinal;

            Console.WriteLine("*** Calculo de Nota Final y Condicion ***");
            Console.WriteLine("Digite su carnet");
            idCarnet = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("A continuacion digite sus notas de los quices");
            Console.WriteLine("Digite la nota del quiz 1");
            quiz1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digita la nota  del quiz 2");
            quiz2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digita la nota  del quiz 3");
            quiz3 = float.Parse(Console.ReadLine());
            Console.WriteLine("A continuacion digite sus notas de las tareas");
            Console.WriteLine("Digite la nota del tarea 1");
            tarea1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digita la nota  del tarea 2");
            tarea2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digita la nota  del tarea 3");
            tarea3 = float.Parse(Console.ReadLine());
            Console.WriteLine("A continuacion digite sus notas de los examenes");
            Console.WriteLine("Digite la nota del examen 1");
            examen1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digita la nota  del examen 2");
            examen2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digita la nota  del examen 3");
            examen3 = float.Parse(Console.ReadLine());
            porcentajeQuices = (quiz1 + quiz2 + quiz3) / 3 * 0.25f;
            porcentajeTareas = (tarea1 + tarea2 + tarea3) / 3 * 0.3f;
            porcentajeExamen = (examen1 + examen2 + examen3) / 3 * 0.45f;
            promedioFinal = porcentajeQuices + porcentajeTareas + porcentajeExamen;

            if(promedioFinal < 50)
            {
                condicion = "Reprobado";
            }else if(promedioFinal < 70) 
            {
                condicion = "Aplazado";
            }else
            {
                condicion = "Aprobado";
            }

            Console.Clear();
            Console.WriteLine("*** Calculo de Nota Final y Condicion ***");
            Console.WriteLine("*** Resultados                        ***");
            Console.WriteLine($"Carnet del usuario {idCarnet}, Nombre del Estudiante: {nombre}");
            Console.WriteLine($"Porcentaje de Quices: {porcentajeQuices} / 25");
            Console.WriteLine($"Porcentaje de Tareas: {porcentajeTareas} / 30");
            Console.WriteLine($"Porcentaje de Examenes: {porcentajeExamen} / 45");
            Console.WriteLine($"Promedio Final: {promedioFinal}");
            Console.WriteLine($"Condicion: {condicion}");
            Console.ReadLine();

        }
    }
}
