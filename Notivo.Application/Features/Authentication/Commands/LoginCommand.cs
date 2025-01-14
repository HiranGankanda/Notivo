using MediatR;

namespace Notivo.Application.Features.Authentication.Commands
{
    public class LoginCommand : IRequest<string>
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}