namespace NeAvito.Contracts.Review
{
    /// <summary>
    /// Модель отзыва на объявление
    /// </summary>
    public class ReviewDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Идентификатор объявления
        /// </summary>
        public Guid AdId { get; set; }

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
        /// Время создания
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Время последнего обновления
        /// </summary>
        public DateTime Updated { get; set; }
    }
}
