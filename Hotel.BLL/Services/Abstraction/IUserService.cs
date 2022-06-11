using System.Collections.Generic;
using Hotel.BLL.Model;

namespace Hotel.BLL.Services.Abstraction
{
    public interface IUserService<T>
    {
        User<T> CreateUser(User<T> user);
        IEnumerable<User<T>> GetAll();
    }
}
