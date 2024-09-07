using NeAvito.Contracts.File;

namespace NeAvito.Application.AppServices.File.Services
{
    /// <summary>
    /// Сервис для работы с файлами
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Добавление файла
        /// </summary>
        /// <param name="fileCreateDto">Модель добавления файла</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Идентификатор</returns>
        public Task<Guid> AddAsync(FileCreateDto fileCreateDto, CancellationToken cancellationToken);

        /// <summary>
        /// Удаление файла
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>False в случае успешного удаления</returns>
        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Получение файла
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель файла</returns>
        public Task<FileDto> GetAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Получение информации о файле
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель информации о файле</returns>
        public Task<FileInfoDto> GetInfoAsync(Guid id, CancellationToken cancellationToken);
    }
}
