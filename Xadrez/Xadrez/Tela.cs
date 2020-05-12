using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;

namespace Xadrez
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiros Tab)
        {
            for (int i = 0; i < Tab.Linhas; i++)
            {
                
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (Tab.peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(Tab.peca(i, j) + " ");

                    }
                }
                Console.WriteLine();

            }
        }
    }
}
