using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Banco
    {
        public int id;
        public int agencia;
        public int conta;
        public string nomeProprietario;
        private double saldo;

        public void SetSaldo(double valor)
        {
            if (valor >= 0)
            {
                saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
        }

        public double Deposito(double valor)
        {
            if (valor >= 0)
            {
                saldo += valor;
            }
            else 
            {
                Console.WriteLine("Valor inválido!");
            }
            return saldo;
        }

        public double Saque(double valor)
        {
            if (valor >= 0)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Valor inválido!");
            }
            return saldo;
        }

        public void Transferir(Banco destino, double valor)
        {
            destino.saldo += valor;
            saldo -= valor;
        }

    }
}
