using System;
using Xadrez.Tabuleiro;
using Xadrez.xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros Tab = new Tabuleiros(8, 8);

            Tab.ColocarUmaPeca(new Torre(Tab,Cor.Preta), new Posicao(0, 0));
            Tab.ColocarUmaPeca(new Torre(Tab, Cor.Preta), new Posicao(1, 3));
            Tab.ColocarUmaPeca(new Rei(Tab, Cor.Preta), new Posicao(4, 4));



            Tela.imprimirTabuleiro(Tab);



            Console.WriteLine();
        }
    }
}
