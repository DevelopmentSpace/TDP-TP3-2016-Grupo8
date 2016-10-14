using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EJ1;

namespace EJ2
{
    class Vaca:Animal
    {
        /// <summary>
        /// Hace el ruido de una vaca.
        /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Muu");
        }
    }
}
