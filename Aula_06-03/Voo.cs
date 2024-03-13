using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_03
{
    public class Voo
    {
        public int Numero;
        public DateTime Data;
        public TimeOnly Hora;
        public int MaxPassageiro;
        //public bool[] vazio = new bool[10];

        public Voo(int n, DateTime dt)
        {
            Numero = n;
            Data = dt;
        }


        //public int ProximoLivre(Voo maxPassageiro, Voo vazio)
        //{
        //    while (true) { }
        //    int poltrona;

        //    return poltrona;
        //}
    }
}
