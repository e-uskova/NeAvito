using Microsoft.AspNetCore.Mvc;
using NeAvito.Application.AppServices.Category.Services;
using NeAvito.Contracts.Category;
using System.Net;

namespace NeAvito.Hosts.Api.Controllers
{
    /// <summary>
    /// Категории объявлений
    /// </summary>
    [ApiController]
    [Route("/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="categoryService">Сервис для работы с категориями объявлений</param>
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Получение всех категорий
        /// </summary>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модели всех категорий</returns>
        [ProducesResponseType(typeof(List<CategoryDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync(CancellationToken cancellationToken)
        {
            var categories = await _categoryService.GetAllAsync(cancellationToken);
            return categories == null ? BadRequest() : Ok(categories);
        }

        /// <summary>
        /// Получение категории по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель категории</returns>
        [ProducesResponseType(typeof(List<CategoryDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetCategoryByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var category = await _categoryService.GetByIdAsync(id, cancellationToken);
            return category == null ? BadRequest() : Ok(category);
        }

        /// <summary>
        /// Добавление категории
        /// </summary>
        /// <param name="categoryCreateDto">Модель создания категории</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Идентификатор категории</returns>
        [ProducesResponseType(typeof(List<CategoryDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpPost]
        public async Task<IActionResult> AddCategoryAsync(CategoryCreateDto categoryCreateDto, CancellationToken cancellationToken)
        {
            var categoryId = await _categoryService.AddAsync(categoryCreateDto, cancellationToken);
            return categoryId == Guid.Empty ? BadRequest() : Ok(categoryId);
        }

        /// <summary>
        /// Изменение категории
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <param name="categoryUpdateDto">Измененная модель категории</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>Модель измененной категории</returns>
        [ProducesResponseType(typeof(CategoryDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateCategoryAsync(Guid id, CategoryUpdateDto categoryUpdateDto, CancellationToken cancellationToken)
        {
            var category = await _categoryService.UpdateAsync(id, categoryUpdateDto, cancellationToken);
            return category == null ? NotFound() : Ok(category);
        }

        /// <summary>
        /// Удаление категории по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор категории</param>
        /// <param name="cancellationToken">Токен отмены</param>
        /// <returns>False при успешном удалении</returns>
        [ProducesResponseType(typeof(bool), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteCategoryByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var result = await _categoryService.DeleteByIdAsync(id, cancellationToken);
            return result ? Ok() : NotFound();
        }
    }
}
