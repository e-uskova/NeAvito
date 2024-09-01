using NeAvito.Application.AppServices.Category.Repository;
using NeAvito.Contracts.Category;

namespace NeAvito.Application.AppServices.Category.Services
{
    /// <inheritdoc/>
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        /// <inheritdoc/>
        public Task<IEnumerable<CategoryDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            return _categoryRepository.GetAllAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CategoryDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return _categoryRepository.GetByIdAsync(id, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<Guid> AddAsync(CategoryCreateDto categoryCreateDto, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();
            var categoryDto = new CategoryDto()
            {
                Id = id,
                Name = categoryCreateDto.Name,
                ParentId = categoryCreateDto.ParentId,
            };
            return _categoryRepository.AddAsync(categoryDto, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CategoryDto> UpdateAsync(Guid id, CategoryUpdateDto categoryUpdateDto, CancellationToken cancellationToken)
        {
            return _categoryRepository.UpdateAsync(id, categoryUpdateDto, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return _categoryRepository.DeleteByIdAsync(id, cancellationToken);
        }
    }
}
