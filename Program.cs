using console_chess.tabuleiro;
using console_chess.xadrez;
using xadrez;

namespace console_chess
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);

                Tela.imprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }   
    }
}
