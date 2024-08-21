namespace NeAvito.Domain
{
    /// <summary>
    /// Прикрепляемый файл
    /// </summary>
    public class File : NamedEntity
    {
        /// <summary>
        /// Контент
        /// </summary>
        public byte[] Content { get; set; }

        /// <summary>
        /// Тип контента
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Размер файла
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Идентификатор объявления, к которому прикреплен файл
        /// </summary>
        public Guid AdId { get; set; }

        /// <summary>
        /// Объявление, к которому прикреплен файл
        /// </summary>
        public Ad Ad { get; set; }
    }
}
