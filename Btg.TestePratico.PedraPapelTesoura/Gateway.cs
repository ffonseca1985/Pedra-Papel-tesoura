using Btg.TestePratico.PedraPapelTesoura.Messages.Bus;
using Btg.TestePratico.PedraPapelTesoura.Messages.Commands;
using System;

namespace Btg.TestePratico.PedraPapelTesoura
{
    public class Gateway
    {
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

            BusInMemory.SendCommands(comecarPartidaCommand);

            Console.WriteLine("############### JOGADORES ################");
            BusInMemory.SendCommands(new AdicionarJogadoresCommand());

            Console.WriteLine("###############################");
            Console.WriteLine("###############################");
            Console.WriteLine("###############################");

            BusInMemory.SendCommands(new AdicionarJogadasCommand() { IdPartida = comecarPartidaCommand.IdPartida });
            Console.WriteLine("###############################");
        }
    }
}
