using System;

namespace exe4_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXE - 1: Tabuada de números");
            Console.WriteLine("\nInsira um número:");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero + "x" + i + " = " + resultado);
            }

            Console.WriteLine("\nEXE - 2: Pular de 3 em 3");
            Console.WriteLine("\nInsira um valor limite:");
            int valorLimiteDe3Em3 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= valorLimiteDe3Em3; i += 3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nEXE - 3: Valor Especial");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("\nInsira um valor:");
                int valorEspecial = int.Parse(Console.ReadLine());

                if (valorEspecial >= 100)
                {
                    Console.WriteLine("Número Especial");
                }
                else
                {
                    Console.WriteLine("Número Comum");
                }
            }

            Console.WriteLine("\nEXE - 4: Repetir Pergunta");
            Console.WriteLine("Deseja Iniciar?");
            char resposta = char.Parse(Console.ReadLine());
            while (resposta == 's')
            {
                Console.WriteLine("Deseja Continuar?");
                resposta = char.Parse(Console.ReadLine());
            }
        }
    }
}