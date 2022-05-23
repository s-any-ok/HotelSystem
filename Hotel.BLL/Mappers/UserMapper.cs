using Hotel.DAL.Entities;

namespace Hotel.BLL.Mappers
{
    public static class UserMapper
    {
        public static User<int> ToModelEntity(this UserEntity userEntity)
        {
            var user = new User<int>()
            {
                Id = userEntity.Id,
                Age = userEntity.Age,
                Name = userEntity.Name,
                LastName = userEntity.LastName,
                Login = userEntity.Login,
                Password = userEntity.Password,
            };

            return user;
        }

        public static UserEntity ToDbEntity(this User<int> user)
        {
            var userEntity = new UserEntity()
            {
                Id = user.Id,
                Age = user.Age,
                Name = user.Name,
                LastName = user.LastName,
                Login = user.Login,
                Password = user.Password,
            };
            return userEntity;
        }
    }
}
