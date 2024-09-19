using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ventas=0, salario=0, total=0, gana=0;
            string nombre;
            int años;
            Console.WriteLine("Ingresa su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa ventas realizadas");
            ventas = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa su salario bruto del mes");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar cantidad de años en la empresa");
            años = int.Parse(Console.ReadLine());
            if (ventas < 600)
            {
                gana = (ventas % 5) + salario;
            }

            if (ventas > 600 && ventas < 3000)
            {
                gana = (ventas % 7) + salario;
            }

            if (ventas > 3000)
            {
                gana = (ventas % 6) + salario + 300;
            }
               if (años <= 3)
               {
                  total = gana - (gana*65/1000);
               }

               if (años >= 4)
               {
                  total = gana - (gana*45/1000);
               }

            Console.WriteLine("Nombre: " +nombre);
            Console.WriteLine("Total ganado: " + gana);
            Console.WriteLine("Descuento del dinero: " +(gana-total));
            Console.WriteLine("Salario neto que recibira: " +total);
            Console.ReadKey();
        }
    }
}

