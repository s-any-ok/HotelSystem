using System;
using System.Collections.Generic;

namespace Hotel.DAL.Entities
{
    public class CategoryEntity : BaseEntity<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public DateTime CreatedData { get; set; } = DateTime.Now;

        public virtual ICollection<RoomEntity> Rooms { get; set; } = new List<RoomEntity>();
    }
}