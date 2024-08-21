namespace NeAvito.Domain
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User : NamedEntity
    {
        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Объявления
        /// </summary>
        public IReadOnlyCollection<Ad> Ads { get; set; }

        /// <summary>
        /// Рейтинг
        /// </summary>
        public double Rating { get; set; }

        /// <summary>
        /// Отзывы, оставленные пользователем
        /// </summary>
        public IReadOnlyCollection<Review> AuthoredReviews { get; set; }
    }
}
