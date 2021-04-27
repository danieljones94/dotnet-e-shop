using e_shop.Models;
using System.Collections.Generic;

namespace e_shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Sweet> SweetsOnSale { get; set; }
    }
}
