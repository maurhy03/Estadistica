using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica
{
    class estadistica
    {
        public double suma = 0;


        public double media(String[] serie)
        {
            foreach(string valor in serie)
            {
                suma += int.Parse(valor);
            }
            return suma / serie.Length;
        }
    }
}
