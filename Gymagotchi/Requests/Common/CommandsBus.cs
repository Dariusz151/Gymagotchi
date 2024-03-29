﻿using System;

namespace Gymagotchi.Requests.Common
{
    public class CommandsBus : ICommandsBus
    {
        private readonly Func<Type, ICommandHandler> _handlersFactory;
        public CommandsBus(Func<Type, ICommandHandler> handlersFactory)
        {
            _handlersFactory = handlersFactory;
        }

        public void Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            var handler = (ICommandHandler<TCommand>)_handlersFactory(typeof(TCommand));
            handler.Handle(command);
        }
    }
}
