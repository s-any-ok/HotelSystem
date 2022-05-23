using System;
using System.Collections.Generic;

namespace Hotel.DAL.Entities
{
    public class RoomEntity : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Information { get; set; }

        public int StatusId { get; set; }
        public virtual StatusEntity Status { get; set; }

        public int CategoryId { get; set; }
        public virtual CategoryEntity Category { get; set; }

        public DateTime CreatedData { get; set; } = DateTime.Now;

        public virtual ICollection<ReservationEntity> Reservations { get; set; } = new List<ReservationEntity>();
    }
}
