using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class FabricaEncriptadores
    {
        //Utilizamos el patron singleton para la fabrica de encriptadores.
        static readonly Lazy<FabricaEncriptadores> cInstancia = new Lazy<FabricaEncriptadores>(() => new FabricaEncriptadores());

        static public FabricaEncriptadores Instancia
        {
            get { return cInstancia.Value; }
        }

        Dictionary<string, IEncriptador> iEncriptadores = new Dictionary<string, IEncriptador> { };

        /// <summary>
        /// Constructor de la fabrica de encriptadores que agrega todos los encriptadores al diccionario de la clase
        /// </summary>
        private FabricaEncriptadores()
        {

            iEncriptadores.Add("César", new EncriptadorCesar(12) );
            iEncriptadores.Add("AES", new EncriptadorAES() );
            iEncriptadores.Add("Null", new EncriptadorNulo());
            iEncriptadores.Add("Clasico", new EncriptadorClasico());
        }

        /// <summary>
        /// Obtiene el encriptador solicitado.
        /// </summary>
        /// <param name="nombre">Nombre del encriptador.</param>
        /// <returns>Encriptador solicitado</returns>
        public IEncriptador GetEncriptador(string nombre)
        {
            if (!iEncriptadores.ContainsKey(nombre))
                return iEncriptadores["Null"];
            return iEncriptadores[nombre];
        }



    }
}
