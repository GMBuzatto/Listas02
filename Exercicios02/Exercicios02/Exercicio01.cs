using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios02
{
    public class Exercicio01
    {
        public string TrocaDeValores(int valorA, int valorB)
        {
            int auxValorA = valorA;
            valorA = valorB;
            valorB = auxValorA;
            return "Valor A: "
                + valorA
                + "\r\nValor B: "
                + valorB;
        }
    }
}
