using NeAvito.Contracts.File;

namespace NeAvito.Application.AppServices.File.Repository
{
    /// <summary>
    /// Репозиторий для работы с файлами
    /// </summary>
    public interface IFileRepository
    {
        /// <summary>
        /// Добавление файла
        /// </summary>
        /// <param name="fileDto">Модель файла</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Идентификатор</returns>
        public Task<Guid> AddAsync(FileDto fileDto, CancellationToken cancellationToken);

        /// <summary>
        /// Удаление файла
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>False при успешном удалении</returns>
        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Получение файла
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель файла</returns>
        public Task<FileDto> GetAsync(Guid id, CancellationToken cancellationToken);
    }
}
