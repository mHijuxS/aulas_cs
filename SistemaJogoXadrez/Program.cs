using tabuleiro;
using xadrez;

namespace SistemaJogoXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);


            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 7));
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 7));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 4));
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}