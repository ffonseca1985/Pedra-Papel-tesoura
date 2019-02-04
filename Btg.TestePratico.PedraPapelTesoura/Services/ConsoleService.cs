using System;

namespace Btg.TestePratico.PedraPapelTesoura.Services
{
    using Btg.TestePratico.PedraPapelTesoura.Bus;
    using Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogador;
    using Btg.TestePratico.PedraPapelTesoura.Events;
    using Btg.TestePratico.PedraPapelTesoura.Repositories;
    using DomainModel.Jogo;

    public class ConsoleService
    {
        public PartidaRepository _partidaRepository;
        public JogadorRepository _jogadorRepository;
        public BusInMemory _busInMemory;

        public ConsoleService()
        {
            _jogadorRepository = new JogadorRepository();
            _partidaRepository = new PartidaRepository();
            _busInMemory = new BusInMemory();
        }

        public void AdicionarJogador()
        {
            if (!ValidarQtdeJogador())
                return;

            string nomeJogador = "";

            while (string.IsNullOrWhiteSpace(nomeJogador))
            {
                System.Console.WriteLine("Favor informar um nome para o Jogador: ");
                nomeJogador = System.Console.ReadLine();
            }

            _jogadorRepository.Add(new Jogador(nomeJogador));
        }

        public void AdicionarJogada(Guid idPartida)
        {
            if (idPartida == default(Guid))
                throw new ApplicationException("Partida não informada");

            var jogadores = _jogadorRepository.Get();
            var partida = _partidaRepository.Get(id: idPartida);

            while (partida.IsOn())
            {
                jogadores.ForEach(jogador =>
                {
                    Console.WriteLine($"Jogador {jogador.Nome}:");
                    Console.WriteLine($"Adicione uma Jogada :");

                    var text = Console.ReadLine();
                    Jogada jogada = null;

                    if (Jogada.Create(text, jogador, ref jogada))
                    {
                        partida.Add(jogada);

                        if (partida.VerificarEmpate())
                        {
                            Console.WriteLine("Deu empate, favor inserir novos dados!!");
                            partida.Clear();
                        }

                        if (partida.VerificarGanhador())
                        {
                            partida.TerminarComVencedor();
                            _busInMemory.SendEvents(new TerminouJogoEvent() { Data = DateTime.Now });
                        }
                    }
                });
            }
        }

        public void AdicionarPartida(Partida partida)
        {
            if (partida == null)
                throw new ApplicationException("Erro ao criar Partida");

            _partidaRepository.Add(partida);
            this.PrintDadosJogo();
        }

        public bool ValidarQtdeJogador()
        {
            return _jogadorRepository.Get().Count < 2;
        }

        public void PrintDadosJogo()
        {
            Console.WriteLine("1 => Pedra");
            Console.WriteLine("2 => Papel");
            Console.WriteLine("3 => Tesoura");
        }
    }
}
