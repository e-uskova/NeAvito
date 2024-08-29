using NeAvito.Application.AppServices.User.Repository;
using NeAvito.Contracts.User;

namespace NeAvito.Application.AppServices.User.Services
{
    /// <inheritdoc/>
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <inheritdoc/>
        public Task<IEnumerable<UserDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            return _userRepository.GetAllAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<UserDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return _userRepository.GetByIdAsync(id, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<Guid> AddAsync(UserCreateDto createDto, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            var userDto = new UserDto()
            {
                Id = id,
                Name = createDto.Name,
                Email = createDto.Email,
                Phone = createDto.Phone,
            };
            var password = createDto.Password; // TODO obfuscation
            return _userRepository.AddAsync(userDto, password, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<UserDto> UpdateAsync(Guid id, UserUpdateDto updateDto, CancellationToken cancellationToken)
        {
            var password = updateDto.Password; // TODO obfuscation
            updateDto.Password = password;
            return _userRepository.UpdateAsync(id, updateDto, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return _userRepository.DeleteByIdAsync(id, cancellationToken);
        }
    }
}
