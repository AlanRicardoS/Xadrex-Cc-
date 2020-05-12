using System;
using System.Collections.Generic;
using System.Text;
using Xadrez.Tabuleiro;

namespace Xadrez.xadrez
{
    class Rei : Peca
    {
        public  Rei(Tabuleiros tab, Cor cor): base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
