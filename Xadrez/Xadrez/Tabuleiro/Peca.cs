using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez.Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, int qtdMovimentos, Tabuleiro tab)
        {
            this.posicao = posicao;
            Cor = cor;
            QtdMovimentos = 0;
            Tab = tab;
        }
    }
}
