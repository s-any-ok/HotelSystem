using System.Collections.Generic;
using Hotel.BLL.Model;

namespace Hotel.API.Model.Response.Room
{
    public class RoomsResponse
    {
        public List<Room<int>> Rooms { get; set; }
    }
}