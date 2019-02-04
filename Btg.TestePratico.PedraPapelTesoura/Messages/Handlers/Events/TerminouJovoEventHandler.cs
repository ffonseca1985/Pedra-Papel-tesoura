using Btg.TestePratico.PedraPapelTesoura.Messages.Events;
using System;

namespace Btg.TestePratico.PedraPapelTesoura.Messages.Handlers.Events
{
    public class TerminouJovoEventHandler : IEventHandler<TerminouJogoEvent>
        , HandlerBase
    {
        private Gateway _gateway;

        public TerminouJovoEventHandler()
        {
            _gateway = new Gateway();
        }

        public void Execute(TerminouJogoEvent @event)
        {
            Console.WriteLine("Quer Começar uma nova Partida (Y)?");
            string result = Console.ReadLine();

            if (result.ToUpper() == "Y")
            {
                _gateway.Recomecar();
            }
            else
            {
                Console.WriteLine("Obrigado por participar do Jogo.");
                Console.WriteLine("Clique em qualquer tecla para sair do Jogo!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
