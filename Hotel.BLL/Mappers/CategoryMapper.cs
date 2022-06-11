using Hotel.BLL.Model;
using Hotel.DAL.Entities;

namespace Hotel.BLL.Mappers
{
    public static class CategoryMapper
    {
        public static Category<int> ToModelEntity(this CategoryEntity categoryEntity)
        {
            var user = new Category<int>()
            {
                Id = categoryEntity.Id,
                Name = categoryEntity.Name,
                Price = categoryEntity.Price,
            };

            return user;
        }

        public static CategoryEntity ToDbEntity(this Category<int> category)
        {
            var userEntity = new CategoryEntity()
            {
                Name = category.Name,
                Price = category.Price,
            };
            return userEntity;
        }
    }
}
