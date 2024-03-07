using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_03
{
    public class Voo
    {
        public int numero;
        public DateTime data;
        public TimeOnly hora;
        public int maxPassageiro;
        public bool[] vazio = new bool[10];

        public Voo(int n, DateTime dt)
        {
            numero = n;
            data = dt;
        }


        //public int ProximoLivre(Voo maxPassageiro, Voo vazio)
        //{
        //    while (true) { }
        //    int poltrona;

        //    return poltrona;
        //}
    }
}
