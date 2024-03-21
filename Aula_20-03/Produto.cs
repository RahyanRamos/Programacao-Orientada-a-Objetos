using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20_03
{
    internal class Produto
    {
        public int id;
        public string descricao;
        private string unidade;
        private double preco;
        public int estoque;

        public void SetPreco(double preco)
        {
            if (preco >= 0)
            {
                this.preco = preco;
            }
            else
            {
                Console.WriteLine("O valor não pode ser negativo.");
            }
        }

        public double GetPreco()
        {
            return preco;
        }

        public void SetUnidade(string unidade)
        {
            unidade = unidade.ToUpper();
            if (unidade == "LT" || unidade == "CX" || unidade == "KG" || unidade == "UN" || unidade == "MT")
            {
                this.unidade = unidade;
            }
            else
            {
                Console.WriteLine("Essa únidade de medida não é válida.");
            }
        }

        public string GetUnidade()
        {
            return unidade;
        }
    }

    //public void SetSaldo(double valor)
    //{
    //    if (valor >= 0)
    //    {
    //        saldo += valor;
    //    }
    //    else
    //    {
    //        Console.WriteLine("Valor inválido!");
    //    }
    //}
}
