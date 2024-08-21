namespace NeAvito.Domain
{
    /// <summary>
    /// Именованная сущность
    /// </summary>
    abstract public class NamedEntity : BaseEntity
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
    }
}
