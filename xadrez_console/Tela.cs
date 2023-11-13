using System;
using System.Runtime.InteropServices.Marshalling;
using jogoDeXadrez;
using tabuleiro;

// Não está com o tabuleiro pois não é um componente e sim o que tornará os componentes visiveis. 
// Classe para criação o tabuleiro visivelmente, utilizando uma função de imprimir o tabuleiro para mostra-lo assim que todas as peças forem colocadas.
namespace xadrez_console
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tabuleiro)
        {

            for (int i = 0; i < tabuleiro.linhas; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.colunas; j++)
                {
                    if (tabuleiro.peca(i, j) == null) // se não houver peça no tabuleiro imprimeiro "-"
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.imprimirPeca(tabuleiro.peca(i, j));
                        Console.Write(" "); // Se houver imprimir a peça
                    }
                }
                Console.WriteLine(); // Quando acabar as colunas pula de linha
            }
            Console.Write("  a b c d e f g h");
            Console.WriteLine();
            
        }


        // Método de imprimir Peça, diferenciando as cores das peças. 
        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

// Método que le a posição escrita pelo o usuário, primeiro uma string que receberá a posição, onde primeiro será o char coluna e o int linha que está sendo convertido em uma string.
        public static PosicaoXadrez lerPosicaoXadrez(){
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + " ");
            return new PosicaoXadrez(coluna, linha);
        }
    }
}