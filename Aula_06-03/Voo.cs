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
        public DateOnly Data;
        public TimeOnly Hora;
        public int MaxPassageiro;
        public bool[] vazio;

        public Voo(int n, DateOnly dt, int vagas)
        {
            Numero = n;
            Data = dt;
            MaxPassageiro = vagas;
            vazio = new bool[MaxPassageiro];
        }

        public int ProximoLivre()
        {
            for (int i = 0; i < vazio.Length; i++)
            {
                if (vazio[i] == false)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        public string VerificaStatus(int poltrona)
        {
            if (vazio[poltrona - 1] == true)
            {
                return "Ocupado";
            }
            else
            {
                return "Desocupado";
            }
        }
    }
}
