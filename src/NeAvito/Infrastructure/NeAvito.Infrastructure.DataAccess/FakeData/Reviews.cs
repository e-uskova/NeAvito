using NeAvito.Domain.Entities;

namespace NeAvito.Infrastructure.DataAccess.FakeData
{
    public static class Reviews
    {
        private static List<Review> _reviews = new()
        {
            new()
            {
                Id = Guid.Parse("320e3e76-7e78-4bd5-a147-13c8e48e9c47"),
                AdId = Guid.Parse("b8ec3ede-4595-4ab1-b6ad-439b35551c0a"),
                Text = "Сделка прошла отлично!",
                Rate = 5,
                AuthorId = Guid.Parse("7fef763c-663b-4668-8ccd-65eab68f3c3c"),
                Created = DateTime.Now,
                Updated = DateTime.Now,
            },
            new()
            {
                Id = Guid.Parse("3922a098-ec53-4c33-a693-1f7d421463ca"),
                AdId = Guid.Parse("b8ec3ede-4595-4ab1-b6ad-439b35551c0a"),
                Text = "Не договорились",
                Rate = 1,
                AuthorId = Guid.Parse("78d80d69-539e-4b8f-9dd2-097fd2db9985"),
                Created = DateTime.Now,
                Updated = DateTime.Now,
            },
        };

        public static IEnumerable<Review> GetAll()
        {
            return _reviews;
        }
    }
}
