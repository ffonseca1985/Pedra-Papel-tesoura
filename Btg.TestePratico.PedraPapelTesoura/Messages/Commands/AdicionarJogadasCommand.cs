using System;

namespace Btg.TestePratico.PedraPapelTesoura.Messages.Commands
{
    public class AdicionarJogadasCommand : ICommand {
        public Guid IdPartida { get; set; }
    }
}
