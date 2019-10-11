namespace Gymagotchi.Requests.Common
{
    public interface ICommandsBus
    {
        void Send<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
