using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um valor a ser multiplicado");
            int num1 = int.Parse(Console.ReadLine());

            int contador = 0;
            int tabela = num1*10; //Cálculo da tabuada

            while (contador <= tabela)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(contador);
                contador = contador+1 * num1; //Multiplicação
            }
            
        }
    }
}
