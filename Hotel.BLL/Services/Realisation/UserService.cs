using System.Collections.Generic;
using System.Linq;
using Hotel.BLL.Mappers;
using Hotel.BLL.Model;
using Hotel.BLL.Services.Abstraction;
using Hotel.DAL.UnitOfWork.Abstraction;

namespace Hotel.BLL.Services.Realisation
{
    public class UserService : IUserService<int>
    {

        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public User<int> CreateUser(User<int> user)
        {
            _unitOfWork.UserRepository.Create(user.ToDbEntity());
            _unitOfWork.Save();
            var result = _unitOfWork.UserRepository.GetById(user.Id).ToModelEntity();
            return user;
        }
        
        public IEnumerable<User<int>> GetAll()
        {
            var result = _unitOfWork
                .UserRepository
                .GetAll()
                .Select(r => r.ToModelEntity());
            return result;
        }

    }
}
