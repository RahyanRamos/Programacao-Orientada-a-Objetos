using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_Prova
{
    public class Circulo
    {
        //A área do círculo corresponde ao valor da superfície dessa figura, levando em conta a
        //medida de seu raio(r). Para calcular a área do círculo devemos utilizar a seguinte
        //fórmula:
        //𝐴 = 𝜋 . 𝑟
        //2
        //Faça um programa C# que possui uma classe Circulo e um atributo raio. Essa classe deve
        //possuir um método que calculo e imprima a área desse círculo.Observação, o valor para
        //o raio deve ser informado pelo usuário.

        public double raio;

        public double Calculo()
        {
            double pi = 3.14;
            double area = pi * raio;

            return area;
        }
    }
}
