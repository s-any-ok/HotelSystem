using System;
using System.Collections.Generic;

namespace Hotel.DAL.Entities
{
    public class StatusEntity : BaseEntity<int>
    {
        public string Name { get; set; }

        public DateTime CreatedData { get; set; } = DateTime.Now;

        public virtual ICollection<RoomEntity> Rooms { get; set; } = new List<RoomEntity>();
    }
}