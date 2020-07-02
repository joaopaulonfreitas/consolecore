using GameTop.Interface;

namespace GameTop
{
    public class JogoFoda
    {
        public readonly iJogador JogadorA;
        public readonly iJogador JogadorB;

        public JogoFoda(iJogador jogadorA, iJogador jogadorB)
        {
            this.JogadorA = jogadorA;
            this.JogadorB = jogadorB;
        }

        public void IniciarJogo()
        {
            // System.Console.WriteLine($"{this.Jogador.Nome} deu um passe");
            System.Console.WriteLine(this.JogadorA.Corre());
            System.Console.WriteLine(this.JogadorA.Chuta());
            System.Console.WriteLine(this.JogadorA.Passe());

            System.Console.WriteLine("\nSegundo Jogador\n");

            System.Console.WriteLine(this.JogadorB.Corre());
            System.Console.WriteLine(this.JogadorB.Chuta());
            System.Console.WriteLine(this.JogadorB.Passe());
        }

    }
}