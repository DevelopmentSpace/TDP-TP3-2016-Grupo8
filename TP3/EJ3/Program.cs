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

            Console.Write("Lista clientes:");

            foreach (var dir in sucursal.ObtenerClientes())
            {
                Console.WriteLine(dir["id"] + " - " + dir["nombre"] + " " + dir["apellido"]);
            }

            Console.Write("Ingrese la id del cliente: ");
            int.TryParse(Console.ReadLine(), out id);

            Console.Write("Ingrese el monto de la solicitud de prestamo: ");
            int.TryParse(Console.ReadLine(), out monto);

            Console.Write("Ingrese la cantidad de meses de la solicitud de prestamo: ");
            int.TryParse(Console.ReadLine(), out cantidadMeses);

            Console.WriteLine(sucursal.SolicitarPrestamo(id, monto, cantidadMeses));

            Console.ReadKey();


        }
    }
}
