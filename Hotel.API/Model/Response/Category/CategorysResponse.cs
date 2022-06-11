using System.Collections.Generic;
using Hotel.BLL.Model;

namespace Hotel.API.Model.Response.Category
{
    public class CategoriesResponse
    {
        public List<Category<int>> Categories { get; set; }
    }
}