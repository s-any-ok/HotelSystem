using System;
using System.Collections.Generic;

namespace Hotel.DAL.Entities
{
    public class UserEntity : BaseEntity<int>
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreatedData { get; set; } = DateTime.Now;

        public virtual ICollection<ReservationEntity> Reservations { get; set; } = new List<ReservationEntity>();
    }
}
