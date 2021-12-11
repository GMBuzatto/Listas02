using System;

namespace Exercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio01");
            Exercicio01 exercicio01 = new Exercicio01();
            Console.WriteLine("Entre com o valorA: ");
            int valorA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o valorB: ");
            int valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(exercicio01.TrocaDeValores(valorA,valorB));
            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("Exercicio02");
            Exercicio02 exercicio02 = new Exercicio02();
            Console.WriteLine("Entre com o valor de x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(exercicio02.Modulo(x));
        }
    }
}
