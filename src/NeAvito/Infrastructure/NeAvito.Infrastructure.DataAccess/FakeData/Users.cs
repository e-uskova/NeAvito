using NeAvito.Domain.Entities;

namespace NeAvito.Infrastructure.DataAccess.FakeData
{
    public static class Users
    {
        private static List<User> _users = new ()
        {
            new()
            {
                Id = Guid.Parse("b9366e2b-15ae-4296-8e5c-15191ad85fdb"),
                Name = "John Doe",
                Email = "johndoe@mail.ru",
                Password = "password",
                Phone = "12345",
                Rating = 3
            },
            new()
            {
                Id = Guid.Parse("7fef763c-663b-4668-8ccd-65eab68f3c3c"),
                Name = "Jane Doe",
                Email = "janedoe@mail.ru",
                Password = "password",
                Phone = "12345",
                Rating = 0
            },
            new()
            {
                Id = Guid.Parse("78d80d69-539e-4b8f-9dd2-097fd2db9985"),
                Name = "Julia Doe",
                Email = "juliadoe@mail.ru",
                Password = "password",
                Phone = "12345",
                Rating = 0
            },
        };

        public static Task<IEnumerable<User>> GetAllASync() 
        { 
            return Task.Run(() => _users.AsEnumerable());
        }

        public static Task<User?> GetByIdAsync(Guid id)
        {
            return Task.Run(() => _users.Where(e => e.Id == id)?.First());
        }

        public static Task<Guid> AddAsync(User model)
        {
            var newUser = model;
            newUser.Id = Guid.NewGuid();
            _users.Add(newUser);
            return Task.Run(() => newUser.Id);
        }
    }
}
