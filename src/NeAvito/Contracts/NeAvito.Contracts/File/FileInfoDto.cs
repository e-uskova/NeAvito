namespace NeAvito.Contracts.File
{
    /// <summary>
    /// Модель информации о файле
    /// </summary>
    public class FileInfoDto
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
    }
}
