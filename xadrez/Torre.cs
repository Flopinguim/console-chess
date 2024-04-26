using console_chess.tabuleiro;

namespace xadrez
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }

        public override string ToString() => "T";

        private bool podeMover(Posicao pos)
        {
            Peca p = tabuleiro.peca(pos);
            return p is null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tabuleiro.linhas, tabuleiro.colunas];

            Posicao posicao = new Posicao(0, 0);

            // acima
            posicao.definirValores(base.posicao.linha - 1, base.posicao.coluna);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                    break;

                posicao.linha = posicao.linha - 1;
            }

            // abaixo
            posicao.definirValores(base.posicao.linha + 1, base.posicao.coluna);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                    break;

                posicao.linha = posicao.linha + 1;
            }

            // direita
            posicao.definirValores(base.posicao.linha, base.posicao.coluna + 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                    break;

                posicao.coluna = posicao.coluna + 1;
            }

            // esquerda
            posicao.definirValores(base.posicao.linha, base.posicao.coluna - 1);
            while (tabuleiro.posicaoValida(posicao) && podeMover(posicao))
            {
                mat[posicao.linha, posicao.coluna] = true;
                if (tabuleiro.peca(posicao) != null && tabuleiro.peca(posicao).cor != cor)
                    break;

                posicao.coluna = posicao.coluna - 1;
            }

            return mat;
        }
    }
}
