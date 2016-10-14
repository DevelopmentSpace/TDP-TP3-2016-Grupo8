using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    public class Veterinaria
    {
        /// <summary>
        ///  Por cada objeto animal en el vector se hace que este haga ruido.
        /// </summary>
        /// <param name="pAnimales"> Vector con objetos de la clase animal</param>
        public void AceptarAnimales(Animal[] pAnimales)
        {
            foreach (Animal animal in pAnimales)
            {
                animal.HacerRuido();
            }
        }
    }
}
