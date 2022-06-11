using Hotel.BLL.Model;

namespace Hotel.API.Model.Commands.Room
{
    public class AddRoomCommand
    {
        public Room<int> Room { get; set; }
    }
}