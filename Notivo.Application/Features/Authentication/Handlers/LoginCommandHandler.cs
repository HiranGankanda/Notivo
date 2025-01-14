using MediatR;
using Notivo.Application.Features.Authentication.Commands;
using Notivo.Application.Interfaces;
using Notivo.Core.Interfaces;
using Notivo.Domain.Entities;

namespace Notivo.Application.Features.Authentication.Handlers
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IUserRepository _userRepository;

        public LoginCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            // Validate user credentials
            var user = await _userRepository.GetByEmailAsync(request.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.Password))
            {
                throw new Exception("Invalid email or password.");
            }

            // Return success (e.g., generate and return JWT in a real-world application)
            return "Login successful";
        }
    }
}