using NeAvito.Contracts.User;

namespace NeAvito.Application.AppServices.User.Services
{
    /// <summary>
    /// Сервис для работы с пользователями
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Получение всех пользователей
        /// </summary>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Массив моделей пользователей</returns>
        public Task<IEnumerable<UserDto>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получение пользователя по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель пользователя</returns>
        public Task<UserDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Добавление пользователя
        /// </summary>
        /// <param name="createDto"></param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Идентификатор добавленного пользователя</returns>
        public Task<Guid> AddAsync(UserCreateDto createDto, CancellationToken cancellationToken);

        /// <summary>
        /// Изменение пользователя
        /// </summary>
        /// <param name="updateDto"></param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Новая модель пользователя</returns>
        public Task<UserDto> UpdateAsync(Guid id, UserUpdateDto updateDto, CancellationToken cancellationToken);

        /// <summary>
        /// Удаление пользователя по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>False при успешном удалении</returns>
        public Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
