using Hotel.BLL.Services.Abstraction;
using Hotel.BLL.Services.Realisation;
using Microsoft.Extensions.DependencyInjection;

namespace Hotel.BLL
{
    public static class DependenciesServices
    {
        public static IServiceCollection SetServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService<int>, UserService>();
            services.AddScoped<IReservationService<int>, ReservationService>();
            services.AddScoped<IRoomService<int>, RoomService>();
            services.AddScoped<ICategoryService<int>, CategoryService>();
            return services;
        }
    }
}
