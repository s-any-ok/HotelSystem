using Hotel.DAL;
using Hotel.DAL.Repositories.Abstraction;
using Hotel.DAL.UnitOfWork.Abstraction;

namespace Hotel.DAL.UnitOfWork.Realisation.EFRealisation
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private HotelContext _dbContext;

        public EFUnitOfWork(HotelContext dbContext,
            IUserRepository userRepository, IRoomRepository roomRepository, IReservationRepository reservationRepository, ICategoryRepository categoryRepository)
        {
            _dbContext = dbContext;

            UserRepository = userRepository;
            RoomRepository = roomRepository;
            ReservationRepository = reservationRepository;
            CategoryRepository = categoryRepository;
        }

        public IUserRepository UserRepository { get; set; }
        public IRoomRepository RoomRepository { get; set; }
        public IReservationRepository ReservationRepository { get; set; }
        public ICategoryRepository CategoryRepository { get; set; }

        ~EFUnitOfWork()
        {
            _dbContext.Dispose();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
