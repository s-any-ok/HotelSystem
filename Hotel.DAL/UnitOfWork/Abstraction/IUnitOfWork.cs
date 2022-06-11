using Hotel.DAL.Repositories.Abstraction;

namespace Hotel.DAL.UnitOfWork.Abstraction
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; set; }
        public IRoomRepository RoomRepository { get; set; }
        public IReservationRepository ReservationRepository { get; set; }
        public ICategoryRepository CategoryRepository { get; set; }
        public void Save();
    }
}
