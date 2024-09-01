namespace NeAvito.Contracts.Category
{
    /// <summary>
    /// Модель изменения категории объявлений
    /// </summary>
    public class CategoryUpdateDto
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
