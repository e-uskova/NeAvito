using NeAvito.Domain.Entities;

namespace NeAvito.Infrastructure.DataAccess.FakeData
{
    public static class Categories
    {
        private static List<Category> _categories = new()
        {
            new()
            {
                Id = Guid.Parse("1ca03977-b99b-4d37-9465-bd67a0a51578"),
                Name = "Недвижимость",
            },
            new()
            {
                Id = Guid.Parse("c1f69754-7fa4-4590-94b0-abc2eba1370f"),
                Name = "Квартиры",
                ParentId = Guid.Parse("1ca03977-b99b-4d37-9465-bd67a0a51578")
            },
            new()
            {
                Id = Guid.Parse("10132ff2-4c9a-472c-b9f6-0b1e1141e3f6"),
                Name = "Дома",
                ParentId = Guid.Parse("1ca03977-b99b-4d37-9465-bd67a0a51578")
            },
        };

        public static IEnumerable<Category> GetAll()
        {
            return _categories;
        }
    }
}
