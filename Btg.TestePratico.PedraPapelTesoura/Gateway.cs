using Btg.TestePratico.PedraPapelTesoura.Bus;
using Btg.TestePratico.PedraPapelTesoura.Commands;
using System;

namespace Btg.TestePratico.PedraPapelTesoura
{
    public class Gateway
    {
        private readonly BusInMemory _busInMemory; 
        public Gateway()
        {
            _busInMemory = new BusInMemory();
        }

        public void Recomecar()
        {
            Console.Clear();
            Comecar();
        }

        public void Comecar()
        {
            var comecarPartidaCommand = new ComecarPartidaCommand()
            {
                IdPartida = Guid.NewGuid(),
                Data = DateTime.Now
            };

            _busInMemory.SendCommands(comecarPartidaCommand);

            Console.WriteLine("############### JOGADORES ################");
            _busInMemory.SendCommands(new AdicionarJogadoresCommand());

            Console.WriteLine("###############################");
            Console.WriteLine("###############################");
            Console.WriteLine("###############################");

            _busInMemory.SendCommands(new AdicionarJogadasCommand() { IdPartida = comecarPartidaCommand.IdPartida });
            Console.WriteLine("###############################");
        }
    }
}
