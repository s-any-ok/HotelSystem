using Hotel.DAL.Entities;
using Hotel.DAL.Repositories.Abstraction;
using System.Linq;

namespace Hotel.DAL.Repositories.Realisation.EFRealisation
{
    public class EFUserRepository : EFGenericRepository<UserEntity, int>, IUserRepository
    {
        public EFUserRepository(HotelContext dbContext) : base(dbContext, dbContext.Users)
        {

        }

        public UserEntity GetUserByCredentialsAsync(string login, string password)
        {
            var user = _dbContext.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
            return new UserEntity
            {
                Id = user.Id,
                Age = user.Age,
                Name = user.Name,
                LastName = user.LastName,
                Login = user.Login
            };

        }
    }
}
