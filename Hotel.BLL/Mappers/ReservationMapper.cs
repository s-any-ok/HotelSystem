using Hotel.BLL.Model;
using Hotel.DAL.Entities;

namespace Hotel.BLL.Mappers
{
    public static class ReservationMapper
    {
        public static Reservation<int> ToModelEntity(this ReservationEntity reservationEntity)
        {
            var reservationModelEntity = new Reservation<int>()
            {
                Id = reservationEntity.Id,
                Duration = reservationEntity.Duration,
                StartTime = reservationEntity.StartTime,
                Room = reservationEntity.Room.ToModelEntity(),
                User = reservationEntity.User.ToModelEntity(),
            };

            return reservationModelEntity;
        }

        public static ReservationEntity ToDbEntity(this Reservation<int> reservationModelEntity)
        {
            var reservationEntity = new ReservationEntity()
            {
                Duration = reservationModelEntity.Duration,
                StartTime = reservationModelEntity.StartTime,
                RoomId = reservationModelEntity.RoomId,
                UserId = reservationModelEntity.UserId,
            };

            return reservationEntity;
        }
    }
}
