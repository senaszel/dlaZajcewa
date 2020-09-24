using CountIt.App.Abstract;
using CountIt.Domain.Common;
using CountIt.Domain.Entity;

namespace CountIt.App.Concrete
{
    public interface ICategoryService<T> : IService<T> where T : BaseEntity
    {
        Category CreateCategory(string name);
        Category GetCategoryByName(string name);
        bool IsCategoryNameExist(string input);
    }
}