using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_
{

    public class Calculo
    {
        static void Main() { }
            public int Area(int d1, int d2)
            {
                return (d1 * d2) / 2;
            }

            public int Perimetro(int l)
            {
                return l * 4;
            }

        }
    

}

