using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        public readonly string Nome;

        public Jogador3(string nome)
        {
            this.Nome = nome;
        }

        public string Chuta()
        {
            return $"{this.Nome}, chutou";
        }

        public string Corre()
        {
            return $"{this.Nome}, correu";
        }

        public string Passe()
        {
            return $"{this.Nome}, passou";
        }
    }
}