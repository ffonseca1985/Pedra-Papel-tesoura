using Btg.TestePratico.PedraPapelTesoura.Commands;
using Btg.TestePratico.PedraPapelTesoura.DomainModel.Jogo;
using Btg.TestePratico.PedraPapelTesoura.Services;

namespace Btg.TestePratico.PedraPapelTesoura.Handlers.Commands
{
    public class ComecarPartidaCommandHandler : ICommandHandler<ComecarPartidaCommand>
        , HandlerBase
    {
        private ConsoleService _consoleService;

        public ComecarPartidaCommandHandler()
        {
            _consoleService = new ConsoleService();
        }

        public void Execute(ComecarPartidaCommand command)
        {
            var partida = new Partida(command.IdPartida);
            _consoleService.AdicionarPartida(partida);
        }
    }
}
