using System.Collections.Generic;
using Btg.TestePratico.PedraPapelTesoura.DomainModel.Extensions;

namespace Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo
{
    using Btg.TestePratico.PedraPapelTesoura.Messages.Bus;
    using Btg.TestePratico.PedraPapelTesoura.Messages.Events;
    using System;
    using System.Collections;
    using System.Linq;

    public class Partida : IEntity<Guid>, ICollection<Jogada>
    {
        public Partida(Guid id)
        {
            this.Id = id;
            this.Jogadas = new List<Jogada>();
            _busInMemory = new BusInMemory();
        }

        private BusInMemory _busInMemory;
        public List<Jogada> Jogadas { get; set; }
        public int Count => this.Jogadas.Count();
        public bool IsReadOnly => true;
        public bool Status { get; set; } = true;

        public IEnumerator<Jogada> GetEnumerator()
        {
            return Jogadas.GetEnumerator();
        }

        public void Comecar()
        {
            this.Status = true;
        }

        public void Terminar()
        {
            this.Status = false;
            BusInMemory.SendEvents(new TerminouJogoEvent() { Data = DateTime.Now });
        }
        public void TerminarComVencedor()
        {
            this.Status = false;

            var vencedor = this.ObterVencedor();
            this.Clear();
            Console.WriteLine($"O vencedor foi: {vencedor.Jogador.Nome} ");

            BusInMemory.SendEvents(new TerminouJogoEvent() { Data = DateTime.Now });
        }

        public bool IsOn() => this.Status;

        private Jogada ObterVencedor()
        {
            Jogada temp = null;
            
            foreach (Jogada jogada in Jogadas)
            {
                temp = temp.ObterSuperior(jogada);
            }
            return temp;
        }

        public bool VerificarEmpate()
        {
            if (!this.VerificarGanhador())
                return false;

            foreach (var jogadaA in Jogadas)
            {
                foreach (Jogada jogadaB in Jogadas)
                {
                    if (jogadaA.TipoJogada.ToString() != jogadaB.TipoJogada.ToString())
                        return false;
                }
            }
            return true;
        }

        public void AdicionarEmpate()
        {
            Console.WriteLine("Deu empate!!");
            this.Terminar();
        }

        public bool VerificarGanhador()
        {
            if (this.Jogadas.Count % 2 == 0)
                return true;

            return false;
        }

        public void Clear()
        {
            this.Jogadas.Clear();
        }

        public bool Contains(Jogada item)
        {
            return this.Jogadas.Contains(item);
        }

        public void CopyTo(Jogada[] array, int arrayIndex)
        {
            this.Jogadas.CopyTo(array, arrayIndex);
        }

        public bool Remove(Jogada item)
        {
            return this.Jogadas.Remove(item);
        }

        public void Add(Jogada item)
        {
            this.Jogadas.Add(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Jogadas.GetEnumerator();
        }
    }
}
    