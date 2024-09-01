using NeAvito.Application.AppServices.Category.Repository;
using NeAvito.Contracts.Category;
using NeAvito.Domain.Entities;
using NeAvito.Infrastructure.DataAccess.FakeData;
using NeAvito.Infrastructure.DataAccess.Mapper;

namespace NeAvito.Infrastructure.DataAccess.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        /*private readonly IRepository<Category> _categoryRepository;

        public CategoryRepository(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }*/

        public async Task<IEnumerable<CategoryDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            var categories = new List<CategoryDto>();
            foreach (Category category in await Categories.GetAllAsync())
            {
                categories.Add(CategoryMap.ToCategoryDto(category));
            }
            return categories;
        }

        public Task<CategoryDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> AddAsync(CategoryDto categoryDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        
        public async Task<CategoryDto> UpdateAsync(Guid id, CategoryUpdateDto categoryUpdateDto, CancellationToken cancellationToken)
        {
            var category = await GetByIdAsync(id, cancellationToken);
            if (category != null)
            {
                if (categoryUpdateDto.Name != null) { category.Name =  categoryUpdateDto.Name; }
                if (categoryUpdateDto.ParentId != null) { category.ParentId =  categoryUpdateDto.ParentId; }
            }
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
