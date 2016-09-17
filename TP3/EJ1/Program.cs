using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales = { new Perro(), new Gato() };
            Veterinaria veterinaria = new Veterinaria();


            char opc;
            do
            {
                Console.Clear();

                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1- Veterinaria: Aceptar animales");
                Console.WriteLine("0- Salir");

                opc = Console.ReadKey().KeyChar;

                Console.Clear();

                switch(opc)
                {
                    case '1':
                        {
                            veterinaria.AceptarAnimales(animales);
                            Console.ReadKey();
                            break;
                        }
                }

            }
            while (opc != '0');
            

        }
    }
}
