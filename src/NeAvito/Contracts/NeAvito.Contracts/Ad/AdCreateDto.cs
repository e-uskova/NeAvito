namespace NeAvito.Contracts.Ad
{
    /// <summary>
    /// Модель создания объявления
    /// </summary>
    public class AdCreateDto
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Адрес
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Идентификатор категории
        /// </summary>
        public Guid CategoryId { get; set; }
    }
}
