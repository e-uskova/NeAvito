using NeAvito.Domain.Base;

namespace NeAvito.Domain.Entities
{
    /// <summary>
    /// Объявление
    /// </summary>
    public class Ad : BaseEntity
    {
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
        /// Категория
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Активно
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Прикрепленные файлы
        /// </summary>
        public IReadOnlyCollection<File> Files { get; set; }

        /// <summary>
        /// Отзывы
        /// </summary>
        public IReadOnlyCollection<Review> Reviews { get; set; }

        /// <summary>
        /// Идентификатор автора
        /// </summary>
        public Guid AuthorId { get; set; }

        /// <summary>
        /// Автор
        /// </summary>
        public User Author { get; set; }

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
