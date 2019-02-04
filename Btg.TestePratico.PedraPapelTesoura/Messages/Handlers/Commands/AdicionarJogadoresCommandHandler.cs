using Btg.TestePratico.PedraPapelTesoura.Messages.Commands;
using Btg.TestePratico.PedraPapelTesoura.Services;

namespace Btg.TestePratico.PedraPapelTesoura.Messages.Handlers.Commands
{
    public class AdicionarJogadoresCommandHandler : ICommandHandler<AdicionarJogadoresCommand>, HandlerBase
    {
        private readonly ConsoleService _service;

        public AdicionarJogadoresCommandHandler()
        {
            _service = new ConsoleService();
        }

        /// <summary>
        /// Como é uma aplicação console não há a necessidade de usar o command
        /// Para aplicações Web os valor viram do client
        /// </summary>
        /// <param name="command"></param>
        public void Execute(AdicionarJogadoresCommand command)
        {
            while (_service.ValidarQtdeJogador()) {

                _service.AdicionarJogador();
            }
        }
    }
}
