namespace NeAvito.Domain.Base
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    abstract public class BaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
    }
}
