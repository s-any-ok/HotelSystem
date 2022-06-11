using System.Collections.Generic;
using Hotel.BLL.Model;

namespace Hotel.API.Model.Response.User
{
    public class UsersResponse
    {
        public List<User<int>> Users { get; set; }
    }
}