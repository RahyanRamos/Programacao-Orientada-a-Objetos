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
        public DateOnly data;
        public TimeOnly hora;
        public int maxPassageiro;
        public bool vazio;

        public Voo(int n, DateOnly dt)
        {
            numero = n;
            data = dt;
        }


        //public int ProximoLivre(Voo maxPassageiro, Voo vazio)
        //{

        //    int poltrona;

        //    return poltrona;
        //}
    }
}
