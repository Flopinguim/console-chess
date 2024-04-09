using console_chess.tabuleiro;

namespace console_chess
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            Tela.imprimirTabuleiro(tabuleiro);
            Console.ReadLine();
        }
    }
}
