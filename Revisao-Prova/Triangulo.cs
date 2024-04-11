using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_Prova
{
    public class Triangulo
    {
        public double aresta1, aresta2, aresta3;

        public double AreaTriangulo()
        {
            double p = (aresta1 + aresta2 + aresta3) / 2;

            double area = Math.Sqrt(p*(p-aresta1)*(p-aresta2)*(p-aresta3));

            return area;
        }
    }
}
