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
        public Tabuleiros Tab { get; protected set; }

        public Peca(Cor cor , Tabuleiros tab)
        {
            this.posicao = null;
            Cor = cor;
            QtdMovimentos = 0;
            Tab = tab;
        }

        public Peca(Tabuleiros tab, Cor cor)
        {
            Tab = tab;
            Cor = cor;
        }
    }
}
