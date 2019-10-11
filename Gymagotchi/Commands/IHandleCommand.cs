using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymagotchi.Commands
{
    public interface IHandleCommand<TCommand> : IHandleCommand
    where TCommand : ICommand
    {
        void Handle(TCommand command);
    }

    public interface IHandleCommand
    {
    }
}
