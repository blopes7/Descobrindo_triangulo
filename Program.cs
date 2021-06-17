using System;

namespace Descobrindo_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            triangulo x;
            x = new triangulo();
            Console.WriteLine("Digite abaixo o valor dos lados do possível triangulo:");

            x.a = double.Parse(Console.ReadLine());
            x.b = double.Parse(Console.ReadLine());
            x.c = double.Parse(Console.ReadLine());

            if (x.a < x.b + x.c)
            {
                Console.WriteLine("É um triângulo");
            }
            else
            {
                Console.WriteLine("Não é um triângulo");

            }
        }
    }
}
