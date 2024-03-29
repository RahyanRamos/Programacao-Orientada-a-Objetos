﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_06_03
{
    public class Voo
    {
        private int Numero;
        private DateOnly Data;
        public TimeOnly Hora;
        public int MaxPassageiro;
        public bool[] vazio;

        public int GetNumero()
        {
            return Numero;
        }

        public DateOnly GetData()
        {
            return Data;
        }

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

        public bool VerificaStatus(int poltrona)
        {
            if (vazio[poltrona - 1] == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Ocupar(int poltrona)
        {
            if (VerificaStatus(poltrona) == false)
            {
                vazio[poltrona - 1] = true;
                return " ";
            }
            else
            {
                return " ";
            }
        }

        public int Vagas()
        {
            int vagasLivres = 0;
            for (int i = 0; i < vazio.Length; i++)
            {
                if (vazio[i] == false)
                {
                    vagasLivres += 1;
                }
            }
            return vagasLivres;
        }
    }
}
