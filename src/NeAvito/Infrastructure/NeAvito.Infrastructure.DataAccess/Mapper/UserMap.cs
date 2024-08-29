using NeAvito.Contracts.User;
using NeAvito.Domain.Entities;

namespace NeAvito.Infrastructure.DataAccess.Mapper
{
    public static class UserMap
    {
        public static UserDto ToUserDto(User user)
        {
            return new()
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Phone = user.Phone,
                Ads = null,
                Rating = user.Rating,
            };
        }

        public static User ToUser(UserDto dto)
        {
            return new()
            {
                Id = dto.Id,
                Name = dto.Name,
                Email = dto.Email,
                Phone = dto.Phone,
                Ads = null,
                Rating = dto.Rating,
            };
        }

        public static User ToUser(UserDto dto, string password)
        {
            return new()
            {
                Id = dto.Id,
                Name = dto.Name,
                Email = dto.Email,
                Phone = dto.Phone,
                Ads = null,
                Rating = dto.Rating,
                Password = password,
            };
        }
    }
}
