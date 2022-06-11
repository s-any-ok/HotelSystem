using System.Collections.Generic;
using Hotel.BLL.Model;

namespace Hotel.BLL.Services.Abstraction
{
    public interface ICategoryService<T>
    {
        Category<T> CreateCategory(Category<T> item);
        IEnumerable<Category<T>> GetAll();
    }
}
