using NeAvito.Application.AppServices.User.Repository;
using NeAvito.Contracts.User;
using NeAvito.Domain.Entities;
using NeAvito.Infrastructure.DataAccess.FakeData;
using NeAvito.Infrastructure.DataAccess.Mapper;

namespace NeAvito.Infrastructure.DataAccess.Repositories
{
    /// <inheritdoc/>
    public class UserRepository : IUserRepository
    {
        /*private readonly IRepository<User> _userRepository;

        public UserRepository(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }*/

        /// <inheritdoc/>
        public async Task<IEnumerable<UserDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            var users = new List<UserDto>();
            foreach (User user in await Users.GetAllASync())
            {
                users.Add(UserMap.ToUserDto(user));
            }
            return users;
        }

        /// <inheritdoc/>
        public async Task<UserDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var user = await Users.GetByIdAsync(id);
            return UserMap.ToUserDto(user);
        }

        /// <inheritdoc/>
        public async Task<Guid> AddAsync(UserDto userDto, string password, CancellationToken cancellationToken)
        {
            var user = UserMap.ToUser(userDto, password);
            return await Users.AddAsync(user);
        }

        /// <inheritdoc/>
        public async Task<UserDto> UpdateAsync(Guid id, UserUpdateDto updateDto, CancellationToken cancellationToken)
        {
            var user = await Users.GetByIdAsync(id);
            if (user != null)
            {
                if (updateDto.Name     != null) { user.Name     = updateDto.Name;}
                if (updateDto.Email    != null) { user.Email    = updateDto.Email; }
                if (updateDto.Phone    != null) { user.Phone    = updateDto.Phone; }
                if (updateDto.Password != null) { user.Password = updateDto.Password; }
            }
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
