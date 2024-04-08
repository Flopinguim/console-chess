using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace console_chess.Tabuleiro
{
    public class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tabuleiro, Cor cor)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tabuleiro = tabuleiro;
            this.quantidadeMovimentos = quantidadeMovimentos;
        }
    }
}
