using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Tabuleiro
{
    class Tabuleiros
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiros(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }
        public Peca peca(int Linha, int Coluna)
        {
            return pecas[Linha, Coluna];
        }
        public void ColocarUmaPeca(Peca P, Posicao Pos)
        {
            pecas[Pos.Linha, Pos.Coluna] = P;
            P.posicao = Pos ;
        }
    }
}
