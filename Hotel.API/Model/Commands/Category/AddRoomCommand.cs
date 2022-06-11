using Hotel.BLL.Model;

namespace Hotel.API.Model.Commands.Category
{
    public class AddCategoryCommand
    {
        public Category<int> Category { get; set; }
    }
}