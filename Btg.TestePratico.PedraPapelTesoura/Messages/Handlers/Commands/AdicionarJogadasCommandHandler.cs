using Btg.TestePratico.PedraPapelTesoura.Messages.Commands;
using Btg.TestePratico.PedraPapelTesoura.Services;

namespace Btg.TestePratico.PedraPapelTesoura.Messages.Handlers.Commands
{
    public class AdicionarJogadasCommandHandler : ICommandHandler<AdicionarJogadasCommand>, HandlerBase
    {
        private readonly ConsoleService _service;

        public AdicionarJogadasCommandHandler()
        {
            _service = new ConsoleService();
        }

        public void Execute(AdicionarJogadasCommand command)
        {
            _service.AdicionarJogada(command.IdPartida);
        }
    }
}
