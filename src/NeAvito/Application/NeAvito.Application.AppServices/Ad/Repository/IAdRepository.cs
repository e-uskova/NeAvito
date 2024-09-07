using NeAvito.Contracts.Ad;

namespace NeAvito.Application.AppServices.Ad.Repository
{
    /// <summary>
    /// Репозиторий для работы с объявлениями
    /// </summary>
    public interface IAdRepository
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
        /// <param name="id">Идентификатор</param>
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
        /// <param name="adDto">Модель создания объявления</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель созданного объявления</returns>
        public Task<AdDto> AddAsync(AdDto adDto, CancellationToken cancellationToken);
    }
}
