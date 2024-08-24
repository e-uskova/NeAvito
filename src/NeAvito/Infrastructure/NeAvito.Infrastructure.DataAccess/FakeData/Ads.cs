using NeAvito.Domain.Entities;

namespace NeAvito.Infrastructure.DataAccess.FakeData
{
    public static class Ads
    {
        private static List<Ad> _ads = new()
        {
            new()
            {
                Id = Guid.Parse("721520bb-0a0f-4e5a-ad6a-6dc766c898d9"),
                Title = "2-к кв 45 кв.м.",
                Description = "Двухкомнатная квартира 45 квадратных метров",
                Price = 30_000,
                Address = "г.Севастополь, пр. Ген. Острякова, д. 220",
                CategoryId = Guid.Parse("1ca03977-b99b-4d37-9465-bd67a0a51578"),
                IsActive = true,
                AuthorId = Guid.Parse("b9366e2b-15ae-4296-8e5c-15191ad85fdb"),
                Created = DateTime.Now,
                Updated = DateTime.Now,
            },
            new()
            {
                Id = Guid.Parse("b8ec3ede-4595-4ab1-b6ad-439b35551c0a"),
                Title = "3-к кв 65 кв.м.",
                Description = "Трешка на Победе",
                Price = 40_000,
                Address = "г.Севастополь, пр. Победы",
                CategoryId = Guid.Parse("1ca03977-b99b-4d37-9465-bd67a0a51578"),
                IsActive = false,
                AuthorId = Guid.Parse("b9366e2b-15ae-4296-8e5c-15191ad85fdb"),
                Created = DateTime.Now,
                Updated = DateTime.Now,
            },
            new()
            {
                Id = Guid.Parse("bbda6efc-c1d3-445a-9cf1-c9ec9bfcbb1e"),
                Title = "Дом 120 кв.м. на участке 4 сот.",
                Description = "Дача на Фиоленте",
                Price = 60_000,
                Address = "г.Севастополь, СНТ Бриз",
                CategoryId = Guid.Parse("10132ff2-4c9a-472c-b9f6-0b1e1141e3f6"),
                IsActive = true,
                AuthorId = Guid.Parse("7fef763c-663b-4668-8ccd-65eab68f3c3c"),
                Created = DateTime.Now,
                Updated = DateTime.Now,
            },
        };

        public static IEnumerable<Ad> GetAll()
        {
            return _ads;
        }
    }
}
