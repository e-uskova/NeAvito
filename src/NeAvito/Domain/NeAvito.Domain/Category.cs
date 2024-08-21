namespace NeAvito.Domain
{
    /// <summary>
    /// Категория объявления
    /// </summary>
    public class Category : NamedEntity
    {
        /// <summary>
        /// Идентификатор родительской категории. Null у корневых
        /// </summary>
        public Guid? ParentId { get; set;}

        /// <summary>
        /// Родительская категория. Null у корневых
        /// </summary>
        public Category? Parent { get; set; }

        /// <summary>
        /// Дочерние категории
        /// </summary>
        public IReadOnlyCollection<Category> Children { get; set;}
    }
}
