using NeAvito.Domain.Base;

namespace NeAvito.Domain.Entities
{
    /// <summary>
    /// Отзыв
    /// </summary>
    public class Review : BaseEntity
    {
        /// <summary>
        /// Идентификатор объявления
        /// </summary>
        public Guid AdId { get; set; }

        /// <summary>
        /// Объявление
        /// </summary>
        public Ad Ad { get; set; }

        /// <summary>
        /// Оценка
        /// </summary>
        public int Rate { get; set; }

        /// <summary>
        /// Текст
        /// </summary>
        public string Text { get; set; }

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
