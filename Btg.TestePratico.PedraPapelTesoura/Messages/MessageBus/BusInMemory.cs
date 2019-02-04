using Btg.TestePratico.PedraPapelTesoura.Messages.Commands;
using Btg.TestePratico.PedraPapelTesoura.Messages.Events;
using Btg.TestePratico.PedraPapelTesoura.Messages.Handlers;
using Btg.TestePratico.PedraPapelTesoura.Messages.Handlers.Commands;
using Btg.TestePratico.PedraPapelTesoura.Messages.Handlers.Events;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Btg.TestePratico.PedraPapelTesoura.Messages.MessageBus
{
    public  class BusInMemory
    {
        private static Dictionary<Type, Type> _handlers = new Dictionary<Type, Type>();

        public static void RegisterCommands<T>() where T : HandlerBase
        {
            Type type = typeof(T);

            var messageType = type.
                GetInterfaces().First(i => i.Name.StartsWith(typeof(ICommandHandler<>).Name));

            _handlers.Add(type, messageType);
        }

        public static void RegisterEvents<T>() where T : HandlerBase
        {
            Type type = typeof(T);

            var messageType = type.
                GetInterfaces().First(i => i.Name.StartsWith(typeof(IEventHandler<>).Name));

            _handlers.Add(type, messageType);
        }

        public static void SendCommands<T>(T command) where T : ICommand
        {
            var type = command.GetType();

            var interfaceCommand = typeof(ICommandHandler<>).MakeGenericType(type);

            var list = _handlers.Keys.Where(x => interfaceCommand.IsAssignableFrom(x))
                    .Select(x => x);

            foreach (Type item in list)
            {
                dynamic intance = Activator.CreateInstance(item);
                intance.Execute(command);
            }
        }

        public static void SendEvents<T>(T @event) where T : IEvent
        {
            var type = @event.GetType();

            var interfaceCommand = typeof(IEventHandler<>).MakeGenericType(type);

            var list = _handlers.Keys.Where(x => interfaceCommand.IsAssignableFrom(x))
                    .Select(x => x);

            foreach (Type item in list)
            {
                dynamic intance = Activator.CreateInstance(item);
                intance.Execute(@event);
            }
        }
    }
}
