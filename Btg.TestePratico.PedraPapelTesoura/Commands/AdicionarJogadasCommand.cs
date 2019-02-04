using System;

namespace Btg.TestePratico.PedraPapelTesoura.Commands
{
    public class AdicionarJogadasCommand : ICommand {
        public Guid IdPartida { get; set; }
    }
}
