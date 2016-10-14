using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Program
    {

        static SucursalPrestamos sucursal = new SucursalPrestamos();

        static void Main(string[] args)
        {

            int id;
            int monto;
            int cantidadMeses;

            while(true)
            {
                Console.Clear();

                //Lista todos los clientes. Estos ya estan establecidos en el constructor de la sucursal.
                Console.WriteLine("Lista clientes:");

                foreach (var dir in sucursal.ObtenerClientes())
                {
                    Console.WriteLine(dir["id"] + " - " + dir["nombre"] + " " + dir["apellido"]);
                }

                //Solicitud de prestamo.
                Console.WriteLine();
                Console.Write("Ingrese la id del cliente (0 para salir): ");
                int.TryParse(Console.ReadLine(), out id);
                if (id == 0)
                    break;

                Console.Write("Ingrese el monto de la solicitud de prestamo: ");
                int.TryParse(Console.ReadLine(), out monto);

                Console.Write("Ingrese la cantidad de cuotas de la solicitud de prestamo: ");
                int.TryParse(Console.ReadLine(), out cantidadMeses);

                //Comprobacion.
                if (sucursal.SolicitarPrestamo(id, monto, cantidadMeses))
                    Console.WriteLine("SOLICITUD VALIDA");
                else
                    Console.WriteLine("SOLICITUD NO VALIDA");

                Console.ReadKey();
            }

            


        }
    }
}
