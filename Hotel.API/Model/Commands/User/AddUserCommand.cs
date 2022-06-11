using Hotel.BLL.Model;

namespace Hotel.API.Model.Commands.User
{
    public class AddUserCommand
    {
        public User<int> User { get; set; }
    }
}