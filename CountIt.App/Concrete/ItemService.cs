using CountIt.App.Common;
using CountIt.Domain.Entity;

namespace CountIt.App.Concrete
{
    public class ItemService : BaseService<Item>, IItemService<Item>
    {

        public void SignDefaultCategoryForAllProductsFromDeletingOne(Category categoryToDelete)
        {
            foreach (var item in Items)
            {
                if (item.CategoryId == categoryToDelete.Id)
                    item.CategoryId = 0;
            }
        }
    }
}
