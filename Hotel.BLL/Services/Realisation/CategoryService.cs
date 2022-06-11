using System.Collections.Generic;
using System.Linq;
using Hotel.BLL.Mappers;
using Hotel.BLL.Model;
using Hotel.BLL.Services.Abstraction;
using Hotel.DAL.UnitOfWork.Abstraction;

namespace Hotel.BLL.Services.Realisation
{
    public class CategoryService : ICategoryService<int>
    {

        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public Category<int> CreateCategory(Category<int> category)
        {
            var entityEntry = _unitOfWork.CategoryRepository.Create(category.ToDbEntity());
            _unitOfWork.Save();
            
            var categoryEntity = _unitOfWork.CategoryRepository.GetById(entityEntry.Entity.Id);
            var result = categoryEntity.ToModelEntity();
            return result;
        }
        
        public IEnumerable<Category<int>> GetAll()
        {
            var result = _unitOfWork
                .CategoryRepository
                .GetAll()
                .Select(r => r.ToModelEntity());
            return result;
        }
    }
}
