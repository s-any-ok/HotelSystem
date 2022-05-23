using System;

namespace Hotel.DAL.Entities
{
    public class ReservationEntity : BaseEntity<int>
    {
        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }

        public int RoomId { get; set; }
        public virtual RoomEntity Room { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; } // in minutes
        public DateTime CreatedData { get; set; } = DateTime.Now;
    }
}
