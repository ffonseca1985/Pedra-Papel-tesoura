using Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Btg.TestePratico.PedraPapelTesoura.Repositories
{
    public class PartidaRepository
    {
        public static List<Partida> Partidas { get; set; } = new List<Partida>();

        public void Add(Partida partida)
        {
            Partidas.Add(partida);
        }

        public List<Partida> Get()
        {
            return Partidas;
        }

        public Partida Get(Guid id)
        {
            return Partidas.FirstOrDefault(x => x.Id == id);
        }
    }
}
