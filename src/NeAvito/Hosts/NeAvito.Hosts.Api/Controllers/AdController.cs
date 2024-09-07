using Microsoft.AspNetCore.Mvc;
using NeAvito.Application.AppServices.Ad.Services;
using NeAvito.Application.AppServices.User.Services;
using NeAvito.Contracts.Ad;

namespace NeAvito.Hosts.Api.Controllers
{
    /// <summary>
    /// Объявления
    /// </summary>
    [ApiController]
    [Route("/ads")]
    public class AdController : ControllerBase
    {
        private readonly IAdService _adService;
        private readonly IUserService _userService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="adService">Сервис для работы с объявлениями</param>
        /// <param name="userService">Сервис для работы с пользователями</param>
        public AdController(IAdService adService, IUserService userService)
        {
            _adService = adService;
            _userService = userService;
        }

        /// <summary>
        /// Получение всех объявлений
        /// </summary>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Массив моделей объявлений</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken)
        {
            var result = await _adService.GetAllAsync(cancellationToken);
            return result == null ? BadRequest() : Ok(result);
        }

        /// <summary>
        /// Получение объявления
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель объявления</returns>
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _adService.GetAsync(id, cancellationToken);
            return result == null ? BadRequest() : Ok(result);
        }

        /// <summary>
        /// Добавление объявления
        /// </summary>
        /// <param name="adCreateDto">Модель создания объявления</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель созданного объявления</returns>
        [HttpPost]
        public async Task<IActionResult> AddAsync(AdCreateDto adCreateDto, CancellationToken cancellationToken)
        {
            var userId = Guid.NewGuid(); //TODO get current user
            var result = await _adService.AddAsync(adCreateDto, userId, cancellationToken);
            return result == null ? BadRequest() : Ok(result);
        }

        /// <summary>
        /// Удаление объявления
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _adService.DeleteAsync(id, cancellationToken);
            return result ? BadRequest() : Ok();
        }

        /// <summary>
        /// Изменение объявления
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="updateDto">Модель изменения объявления</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Измененная модель объявления</returns>
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateAsync(Guid id, AdUpdateDto updateDto, CancellationToken cancellationToken)
        {
            var result = await _adService.UpdateAsync(id, updateDto, cancellationToken);
            return result == null ? BadRequest() : Ok(result);
        }
    }
}
