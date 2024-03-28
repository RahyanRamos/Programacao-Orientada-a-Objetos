using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AtividadeAvaliativa_Multas.RegrasDeNegocio
{
    public static class Validacoes
    {
        public static bool ValidarCpf(string cpf)
        {
            int[] digitos = new int[11];
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length == 11)
            {
                for (int i = 0; i < cpf.Length; i++)
                {
                    digitos[i] = Convert.ToInt32(cpf[i].ToString());
                }

                for (int i = 0; i < digitos.Length; i++)
                {
                    int multiplica = 10;
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
