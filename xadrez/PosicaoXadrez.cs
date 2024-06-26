﻿using console_chess.tabuleiro;

namespace console_chess.xadrez
{
    public class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao() => new Posicao(8 - linha, coluna - 'a');

        public override string ToString() => "" + coluna + linha;


    }
}
