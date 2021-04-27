using e_shop.Interfaces;
using e_shop.Models;
using System.Collections.Generic;

namespace e_shop.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;
    }
}
