using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EJ1;

namespace EJ2
{
    class Cerdo:Animal
    {
        /// <summary>
        /// Hace el ruido de un cerdo.
        /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Oink");
        }
    }
}
