namespace NeAvito.Contracts.Category
{
    /// <summary>
    /// Модель создания категории объявлений
    /// </summary>
    public class CategoryCreateDto
    {
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
