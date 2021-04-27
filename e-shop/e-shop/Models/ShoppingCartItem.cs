namespace e_shop.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public string ShoppingCartId { get; set; }
        public Sweet Sweet { get; set; }
        public int Quantity { get; set; }
    }
}
