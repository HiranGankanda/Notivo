using MediatR;

namespace Notivo.Application.Features.Authentication.Commands
{
    public class RegisterUserCommand : IRequest<Guid>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
    }
}