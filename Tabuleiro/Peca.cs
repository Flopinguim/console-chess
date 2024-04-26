namespace console_chess.tabuleiro
{
    public abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tabuleiro = tab;
            this.cor = cor;
            this.quantidadeMovimentos = 0;
        }

        public void incrementarQteMovimentos() => quantidadeMovimentos++;

        public abstract bool[,] movimentosPossiveis();
    }
}