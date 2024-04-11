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
            int[] primeiroMult = new int[9];
            int[] segundoMult = new int[10];
            int multiplica, primeiroSoma, primeiroMod, primeiroVerif, segundoSoma, segundoMod, segundoVerif;
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length == 11)
            {
                for (int i = 0; i < cpf.Length; i++)
                {
                    digitos[i] = Convert.ToInt32(cpf[i].ToString());
                }

                multiplica = 10;
                for (int i = 0; i < digitos.Length - 2; i++)
                {
                    primeiroMult[i] = digitos[i] * multiplica;
                    multiplica--;
                }

                primeiroSoma = primeiroMult.Sum();

                primeiroMod = primeiroSoma % 11;

                if (primeiroMod < 2)
                {
                    primeiroVerif = 0;
                }
                else
                {
                    primeiroVerif = 11 - primeiroMod;
                }

                if (primeiroVerif == digitos[9])
                {
                    multiplica = 11;
                    for (int i = 0; i < digitos.Length - 1; i++)
                    {
                        segundoMult[i] = digitos[i] * multiplica;
                        multiplica--;
                    }

                    segundoSoma = segundoMult.Sum();

                    segundoMod = segundoSoma % 11;

                    if (segundoMod < 2)
                    {
                        segundoVerif = 0;
                    }
                    else
                    {
                        segundoVerif = 11 - segundoMod;
                    }

                    if (segundoVerif == digitos[10])
                    {
                        Console.WriteLine("CPF válido!");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("CPF inválido!");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("CPF inválido!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("CPF inválido!");
                return false;
            }
        }

        public static bool ValidarNiv(string niv)
        {
            niv = niv.ToUpper();

            if (niv.Length == 17)
            {
                if (niv.Contains("O") || niv.Contains("Q") || niv.Contains("I"))
                {
                    Console.WriteLine("NIV inválido por conter O, Q ou I");
                    return false;
                }
                else
                {
                    for (int i = 13; i <= niv.Length; i++)
                    {
                        if (!char.IsDigit(niv[i]))
                        {
                            Console.WriteLine("Os 4 últimos digitos não pode ter letra");
                            return false;
                        }
                        else
                        {
                            Console.WriteLine("NIV válido");
                            return true;
                        }
                    }
                    return true;
                }
            }
            else
            {
                Console.WriteLine("NIV inválido!");
                return false;
            }
        }
    }
}
