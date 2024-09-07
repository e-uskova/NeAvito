using NeAvito.Contracts.Ad;

namespace NeAvito.Application.AppServices.Ad.Services
{
    /// <summary>
    /// Сервис для работы с объявлениями
    /// </summary>
    public interface IAdService
    {
        /// <summary>
        /// Получение всех объявлений
        /// </summary>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns></returns>
        public Task<IEnumerable<AdDto>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получение объявления по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns></returns>
        public Task<AdDto> GetAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Удаление объявления
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns></returns>
        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Изменение объявления
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="adUpdateDto">Модель изменений объявления</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Измененная модель объявления</returns>
        public Task<AdDto> UpdateAsync(Guid id, AdUpdateDto adUpdateDto, CancellationToken cancellationToken);

        /// <summary>
        /// Добавление объявления
        /// </summary>
        /// <param name="adCreateDto">Модель создания объявления</param>
        /// <param name="userId">Идентификатор текущего пользователя</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель созданного объявления</returns>
        public Task<AdDto> AddAsync(AdCreateDto adCreateDto, Guid userId, CancellationToken cancellationToken);
    }
}
