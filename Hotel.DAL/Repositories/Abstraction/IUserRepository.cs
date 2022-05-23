using Hotel.DAL.Entities;
using System.Collections.Generic;

namespace Hotel.DAL.Repositories.Abstraction
{
    public interface IUserRepository : IRepository<UserEntity, int>
    {
        public UserEntity GetUserByCredentialsAsync(string login, string password);
    }
}
