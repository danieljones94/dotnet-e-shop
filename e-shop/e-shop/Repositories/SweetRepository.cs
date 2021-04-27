using e_shop.Interfaces;
using e_shop.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace e_shop.Repositories
{
    public class SweetRepository : ISweetRepository
    {

        private readonly AppDbContext _appDbContext;

        public SweetRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Sweet> GetAllSweets {
            get {
                return _appDbContext.Sweets.Include(o => o.Category);
            }

        }

        public IEnumerable<Sweet> GetSweetsOnSale()
        {
            return _appDbContext.Sweets.Include(o => o.Category).Where(o => o.IsOnSale);
        }

        public Sweet GetSweetById(int id)
        {
            return _appDbContext.Sweets.Include(o => o.Category).FirstOrDefault(o => o.Id == id);
        }
    }
}
