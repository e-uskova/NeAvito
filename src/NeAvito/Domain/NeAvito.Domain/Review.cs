namespace NeAvito.Domain
{
    /// <summary>
    /// Отзыв
    /// </summary>
    public class Review : UserEntry
    {
        /// <summary>
        /// Идентификатор объявления
        /// </summary>
        public Guid AdId { get; set; }

        /// <summary>
        /// Объявление
        /// </summary>
        public Ad Ad {  get; set; }

        /// <summary>
        /// Оценка
        /// </summary>
        public int Rate { get; set; }

        /// <summary>
        /// Текст
        /// </summary>
        public string Text { get; set; }
    }
}
