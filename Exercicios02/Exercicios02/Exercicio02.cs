using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios02
{
    public class Exercicio02
    {
        public string Modulo(int x)
        {
             if(x>= 0)
            {
                Console.WriteLine($"{x} e maior ou igual a 0.");
            }
            else
            {
                Console.Write($"{x} e menor doque 0.");
            }
            return "";
        }
    }
}
