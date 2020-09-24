using CountIt.App.Abstract;
using CountIt.Domain.Common;
using CountIt.Domain.Entity;

namespace CountIt.App.Concrete
{
    public interface IItemService<T> : IService<T> where T : BaseEntity
    {
        void SignDefaultCategoryForAllProductsFromDeletingOne(Category categoryToDelete);
    }
}