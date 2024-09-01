namespace NeAvito.Contracts.Category
{
    /// <summary>
    /// Модель категории объявлений
    /// </summary>
    public class CategoryDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Идентификатор родительской категории. Null у корневых
        /// </summary>
        public Guid? ParentId { get; set; }
    }
}
