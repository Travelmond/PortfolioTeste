using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculoController : ControllerBase
    {
        [HttpGet]
        [Route("Area/{d1:int}/{d2:int}")]
        public int Area(int d1, int d2)
        {
            Calculo Calculo = new Calculo();
            return Calculo.Area(d1, d2);
        }

        [HttpGet]
        [Route("Perimetro/{l:int}")]
        public int Perimetro(int l)
        {
            Calculo Calculo = new Calculo();
            return Calculo.Perimetro(l);
        }
    }
}
