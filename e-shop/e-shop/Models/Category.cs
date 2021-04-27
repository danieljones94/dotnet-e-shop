using System.Collections.Generic;

namespace e_shop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Sweet> Sweets { get; set; }
    }
}
