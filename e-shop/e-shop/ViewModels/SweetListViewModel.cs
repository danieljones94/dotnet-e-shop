using e_shop.Models;
using System.Collections.Generic;

namespace e_shop.ViewModels
{
    public class SweetListViewModel
    {
        public IEnumerable<Sweet> Sweets { get; set; }
        public string CurrentCategory { get; set; }
    }
}
