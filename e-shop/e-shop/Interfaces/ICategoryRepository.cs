using e_shop.Models;
using System.Collections.Generic;

namespace e_shop.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
