using System;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros Tab = new Tabuleiros(8, 8);

            Tela.imprimirTabuleiro(Tab);
            Console.WriteLine();
        }
    }
}
