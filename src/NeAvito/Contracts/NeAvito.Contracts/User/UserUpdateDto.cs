namespace NeAvito.Contracts.User
{
    public class UserUpdateDto
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string? Phone { get; set; }
    }
}
