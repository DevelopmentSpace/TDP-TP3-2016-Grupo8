using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EJ1;

namespace EJ2
{
    class Gallo:Animal
    {
        /// <summary>
        /// Hace le ruido de un gallo.
        /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Kirkiriki");
        }
    }
}
