using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class FabricaEncriptadores
    {

        static readonly Lazy<FabricaEncriptadores> cInstancia = new Lazy<FabricaEncriptadores>(() => new FabricaEncriptadores());

        static public FabricaEncriptadores Instancia
        {
            get { return cInstancia.Value; }
        }

        Dictionary<string, IEncriptador> iEncriptadores;

        private FabricaEncriptadores()
        {
            iEncriptadores.Add("César", new EncriptadorCesar(12) );
            iEncriptadores.Add("AES", new EncriptadorAES() );
            iEncriptadores.Add("Null", new EncriptadorNulo());
        }

        public IEncriptador GetEncriptador(string nombre)
        {
            if (!iEncriptadores.ContainsKey(nombre))
                return iEncriptadores["Null"];
            return iEncriptadores[nombre];
        }



    }
}
