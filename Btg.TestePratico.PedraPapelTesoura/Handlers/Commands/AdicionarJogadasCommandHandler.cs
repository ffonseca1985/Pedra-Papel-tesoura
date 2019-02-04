using Btg.TestePratico.PedraPapelTesoura.Commands;
using Btg.TestePratico.PedraPapelTesoura.Services;
using System;

namespace Btg.TestePratico.PedraPapelTesoura.Handlers.Commands
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
