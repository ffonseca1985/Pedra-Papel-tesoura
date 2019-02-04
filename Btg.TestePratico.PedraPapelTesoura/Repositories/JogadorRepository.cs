using System.Collections.Generic;

namespace Btg.TestePratico.PedraPapelTesoura.Repositories
{
    using DomainModel.Jogador;
    public class JogadorRepository
    {
        private static List<Jogador> Jogadores { get; set; } = new List<Jogador>();

        public void Add(Jogador jogador)
        {
            Jogadores.Add(jogador);
        }

        public List<Jogador> Get()
        {
            return Jogadores;
        }
    }
}
