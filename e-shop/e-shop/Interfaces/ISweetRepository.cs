using e_shop.Models;
using System.Collections.Generic;

namespace e_shop.Interfaces
{
    public interface ISweetRepository
    {
        IEnumerable<Sweet> GetAllSweets { get; }
        IEnumerable<Sweet> GetSweetsOnSale();
        Sweet GetSweetById(int id);
    }
}
