using Gymagotchi.Requests.Common;
using Gymagotchi.Services;
using Microsoft.AspNetCore.Identity;

namespace Gymagotchi.Requests.Commands.Handlers
{
    public class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
    {
        private readonly IUserService _userService;

        public DeleteUserCommandHandler(IUserService userService)
        {
            _userService = userService;
        }

        public void Handle(DeleteUserCommand command)
        {
            _userService.DeleteUserAsync(command.UserId);
        }
    }
}
