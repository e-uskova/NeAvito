namespace NeAvito.Domain
{
    /// <summary>
    /// Запись, созданная пользователем
    /// </summary>
    abstract public class UserEntry : BaseEntity
    {
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
        public DateTime Created {  get; set; }

        /// <summary>
        /// Время последнего обновления
        /// </summary>
        public DateTime Updated { get; set; }
    }
}
