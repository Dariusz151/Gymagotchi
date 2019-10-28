using Gymagotchi.Requests.Common;

namespace Gymagotchi.Requests.Commands
{
    public class DeleteUserCommand : ICommand
    {
        public string UserId { get; set; }

        public DeleteUserCommand()
        {

        }

        public DeleteUserCommand(string userId)
        {
            UserId = userId;
        }
    }
}
