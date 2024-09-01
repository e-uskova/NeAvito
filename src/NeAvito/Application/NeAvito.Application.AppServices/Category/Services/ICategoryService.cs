using NeAvito.Contracts.Category;

namespace NeAvito.Application.AppServices.Category.Services
{
    /// <summary>
    /// Сервис для работы с категориями объявлений
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// Получение всех категорий
        /// </summary>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Массив моделей категорий</returns>
        public Task<IEnumerable<CategoryDto>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Получение категории по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель категории</returns>
        public Task<CategoryDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);

        /// <summary>
        /// Добавление категории
        /// </summary>
        /// <param name="categoryCreateDto">Модель категории</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Идентификатор добавленного категории</returns>
        public Task<Guid> AddAsync(CategoryCreateDto categoryCreateDto, CancellationToken cancellationToken);

        /// <summary>
        /// Изменение категории
        /// </summary>
        /// <param name="categoryUpdateDto">Модель изменений категории</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Новая модель категории</returns>
        public Task<CategoryDto> UpdateAsync(Guid id, CategoryUpdateDto categoryUpdateDto, CancellationToken cancellationToken);

        /// <summary>
        /// Удаление категории по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>False при успешном удалении</returns>
        public Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
