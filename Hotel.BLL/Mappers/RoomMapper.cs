using Hotel.BLL.Model;
using Hotel.DAL.Entities;

namespace Hotel.BLL.Mappers
{
    public static class RoomMapper
    {
        public static Room<int> ToModelEntity(this RoomEntity roomEntity)
        {
            var roomModelEntity = new Room<int>()
            {
                Name = roomEntity.Name,
                Information = roomEntity.Information
            };

            return roomModelEntity;
        }

        public static RoomEntity ToDbEntity(this Room<int> roomModelEntity)
        {
            var roomEntity = new RoomEntity()
            {
                Id = roomModelEntity.Id,
                Name = roomModelEntity.Name,
                Information = roomModelEntity.Information
            };

            return roomEntity;
        }
    }
}
