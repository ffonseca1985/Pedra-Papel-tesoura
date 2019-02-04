namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogador
{
    using Jogo;
    public class Jogador : IEntity<int>
    {
        public Jogador(string nome)
        {
            this.Nome = nome;
        }
        public string Nome { get; set; }
    }
}
