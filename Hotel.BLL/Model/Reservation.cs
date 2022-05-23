using System;

namespace Hotel.DAL.Entities
{
    public class Reservation<TKey>
    {
        public TKey Id { get; set; }
        public TKey UserId { get; set; }
        public TKey RoomId { get; set; }

        public int Duration { get; set; } // in minutes

        public DateTime StartTime { get; set; }
    }
}
