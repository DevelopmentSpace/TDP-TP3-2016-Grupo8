﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    public class Gato: Animal
    {
        /// <summary>
        /// Hace ruido de gato.
        /// </summary>
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
        }
    }
}
