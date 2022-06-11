using Hotel.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel.DAL
{
    public class HotelContext : DbContext
    {
        public virtual DbSet<UserEntity> Users { get; set; }
        public virtual DbSet<ReservationEntity> Reservations { get; set; }
        public virtual DbSet<RoomEntity> Rooms { get; set; }
        public virtual DbSet<CategoryEntity> Categories { get; set; }

        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}