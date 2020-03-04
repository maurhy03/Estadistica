using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica
{
    class moneda
    {
        public string[][] conversor =
            {
            new string[]{"Dolares", "Colones SV", "Rupia", "Yenes", "Peso Chileno", "Peso MX", "Peso Argentino", "BItcoin"},
     };
        public Double[][] Valores =
         {
            new double[] {1, 8.50, 111.27, 69.75, 667.08, 19.36, 39.69, 0.00026 },
        };
        public double convertir(int opcion, int de, int a, double cantidad)
        {
            return Valores[opcion][a] / Valores[opcion][de] * cantidad;
        }
    }
}
