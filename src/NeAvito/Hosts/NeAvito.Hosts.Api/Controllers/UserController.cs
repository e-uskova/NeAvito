using Microsoft.AspNetCore.Mvc;
using NeAvito.Application.AppServices.User.Services;
using NeAvito.Contracts.User;
using System.Net;

namespace NeAvito.Hosts.Api.Controllers
{
    /// <summary>
    /// Пользователи
    /// </summary>
    [ApiController]
    [Route("/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="userService">Сервис для работы с пользователями</param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Получение всех пользователей
        /// </summary>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модели всех зарегистрированных пользователей</returns>
        [ProducesResponseType(typeof(List<UserDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet]
        public async Task<IActionResult> GetAllUsersAsync(CancellationToken cancellationToken)
        {
            var users = await _userService.GetAllAsync(cancellationToken);
            return users == null ? NotFound() : Ok(users);
        }

        /// <summary>
        /// Получение пользователя по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель пользователя</returns>
        [ProducesResponseType(typeof(UserDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetUserByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var user = await _userService.GetByIdAsync(id, cancellationToken);
            return user == null ? NotFound() : Ok(user);
        }

        /// <summary>
        /// Добавление пользователя
        /// </summary>
        /// <param name="userCreateDto">Модель создания пользователя</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Идентификатор добавленного пользователя</returns>
        [ProducesResponseType(typeof(Guid), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpPost]
        public async Task<IActionResult> AddUserAsync(UserCreateDto userCreateDto, CancellationToken cancellationToken)
        {
            var userId = await _userService.AddAsync(userCreateDto, cancellationToken);
            return userId == Guid.Empty ? BadRequest() : Ok(userId);
        }

        /// <summary>
        /// Изменение пользователя
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <param name="userUpdateDto">Измененная модель пользователя</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Новая модель пользователя</returns>
        [ProducesResponseType(typeof(UserDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateUserAsync(Guid id, UserUpdateDto userUpdateDto, CancellationToken cancellationToken)
        {
            var user = await _userService.UpdateAsync(id, userUpdateDto, cancellationToken);
            return user == null ? NotFound() : Ok(user);
        }

        /// <summary>
        /// Удаление пользователя по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>False при успешном удалении</returns>
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteUserByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _userService.DeleteByIdAsync(id, cancellationToken);
            return result ? Ok() : NotFound();
        }
    }
}
