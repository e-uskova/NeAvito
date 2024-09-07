using NeAvito.Contracts.File;
using NeAvito.Contracts.Review;

namespace NeAvito.Contracts.Ad
{
    /// <summary>
    /// Модель объявления
    /// </summary>
    public class AdDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public Guid CategoryId { get; set; }

        /// <summary>
        /// Активно
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Прикрепленные файлы
        /// </summary>
        public IReadOnlyCollection<FileDto> Files { get; set; }

        /// <summary>
        /// Отзывы
        /// </summary>
        public IReadOnlyCollection<ReviewDto> Reviews { get; set; }

        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Время последнего обновления
        /// </summary>
        public DateTime Updated { get; set; }
    }
}
