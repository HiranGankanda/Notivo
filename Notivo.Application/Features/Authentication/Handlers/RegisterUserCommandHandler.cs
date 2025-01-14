using MediatR;
using Notivo.Application.Features.Authentication.Commands;
using Notivo.Application.Interfaces;
using Notivo.Core.Domain.Entities;
using Notivo.Core.Interfaces;
using Notivo.Domain.Entities;

namespace Notivo.Application.Features.Authentication.Handlers
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, Guid>
    {
        private readonly IUserRepository _userRepository;

        public RegisterUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            // Validate if user already exists
            var existingUser = await _userRepository.GetByEmailAsync(request.Email);
            if (existingUser != null)
            {
                throw new Exception("User with this email already exists.");
            }

            // Create new user
            var user = new User
            {
                Id = Guid.NewGuid(),
                Email = request.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(request.Password),
                FullName = request.FullName
            };

            await _userRepository.AddAsync(user);

            return user.Id;
        }
    }
}