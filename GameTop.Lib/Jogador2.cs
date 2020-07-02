using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
         public readonly string Nome;

        public Jogador2(string nome)
        {
            this.Nome = nome;
        }

        // Chuta
        public string Chuta()
        {
            return $"{Nome} está chutando";
        }
        
        // Corre
        public string Corre()
        {
            return $"{Nome} está correndo";
        }

        // Passe
        public string Passe()
        {
            return $"{Nome} está passando";
        }
    }
}