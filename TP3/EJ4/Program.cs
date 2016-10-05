using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class Program
    {

        static Criptografia cripto = new Criptografia();

        static void Main(string[] args)
        {

            char opt;

            do
            {
                Console.Clear();

                Console.WriteLine("1 - Encriptar");
                Console.WriteLine("2 - Desencriptar");
                Console.WriteLine("0 - Salir");
                Console.WriteLine();
                Console.Write("Ingrese una opcion: ");

                opt = Console.ReadKey().KeyChar;

                switch (opt)
                {
                    case '1':
                        {
                            MenuEncriptar();
                            break;
                        }
                    case '2':
                        {
                            MenuDesencriptar();
                            break;
                        }
                }

            }
            while (opt != '0');


        }

        static void MenuEncriptar()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del encriptador a usar (César - AES - Null): ");
            string nombreEnc = Console.ReadLine();
            Console.Write("Ingrese la cadena: ");
            string cadena = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Resultado: ");
            Console.WriteLine(cripto.Encriptar(cadena, nombreEnc));
            Console.ReadKey();
        }

        static void MenuDesencriptar()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del encriptador a usar (César - AES - Null): ");
            string nombreEnc = Console.ReadLine();
            Console.Write("Ingrese la cadena: ");
            string cadena = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Resultado: ");
            Console.WriteLine(cripto.Desencriptar(cadena, nombreEnc));
            Console.ReadKey();
        }
    }
}
