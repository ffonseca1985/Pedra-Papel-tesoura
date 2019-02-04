using Btg.TestePratico.PedraPapelTesoura.Bus;
using Btg.TestePratico.PedraPapelTesoura.Commands;
using Btg.TestePratico.PedraPapelTesoura.Events;
using Btg.TestePratico.PedraPapelTesoura.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Btg.TestePratico.PedraPapelTesoura.Handlers.Events
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
