// Na classe posição nós temos a posição que a peça estará, na linha e coluna determinada. 

namespace tabuleiro
{
    public class Posicao
    {
        public int linha { get; set; }
        public int coluna { get; set; }
        public Posicao()
        {
        }
        public Posicao(int linha, int coluna) // Criamos um construtor que diz que a posição recebe (linha, coluna)
        {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString()
        {
            return linha
            + ", "
            + coluna
            ;
        }
    }
}

