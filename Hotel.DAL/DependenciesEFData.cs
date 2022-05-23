using Hotel.DAL.Repositories.Abstraction;
using Hotel.DAL.Repositories.Realisation.EFRealisation;
using Hotel.DAL.UnitOfWork.Abstraction;
using Hotel.DAL.UnitOfWork.Realisation.EFRealisation;
using Microsoft.Extensions.DependencyInjection;

namespace Hotel.DAL
{
    public static class DependenciesEFData
    {
        public static IServiceCollection SetEFDataDependencies(this IServiceCollection services)
        {
            services.AddScoped<HotelContext>();
            services.AddScoped<IUserRepository, EFUserRepository>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();
            services.AddScoped<IReservationRepository, EFReservationRepository>();
            services.AddScoped<IRoomRepository, EFRoomRepository>();
            services.AddScoped<IStatusRepository, EFStatusRepository>();
            services.AddScoped<IUnitOfWork, EFUnitOfWork>();
            return services;
        }
    }
}
