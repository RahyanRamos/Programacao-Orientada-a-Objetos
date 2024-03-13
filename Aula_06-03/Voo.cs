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
        bool[] vazio;

        public Voo(int n, DateTime dt, int vagas)
        {
            Numero = n;
            Data = dt;
            vazio = new bool[MaxPassageiro];
            MaxPassageiro = vagas;
        }


        //public int ProximoLivre(Voo maxPassageiro, Voo vazio)
        //{
        //    while (true) { }
        //    int poltrona;

        //    return poltrona;
        //}
    }
}
