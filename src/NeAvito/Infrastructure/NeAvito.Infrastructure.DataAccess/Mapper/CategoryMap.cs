using NeAvito.Contracts.Category;
using NeAvito.Domain.Entities;

namespace NeAvito.Infrastructure.DataAccess.Mapper
{
    public static class CategoryMap
    {
        public static Category ToCategory(CategoryDto categoryDto)
        {
            return new()
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
                ParentId = categoryDto.ParentId,
            };
        }

        public static CategoryDto ToCategoryDto(Category category)
        {
            return new()
            {
                Id = category.Id,
                Name = category.Name,
                ParentId = category.ParentId,
            };
        }
    }
}
