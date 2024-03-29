﻿namespace Gymagotchi.Requests.Common
{
    public interface ICommandHandler<TCommand> : ICommandHandler
    where TCommand : ICommand
    {
        void Handle(TCommand command);
    }

    public interface ICommandHandler
    {
    }
}
