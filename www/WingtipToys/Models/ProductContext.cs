using System.Data.Entity;
namespace WingtipToyx.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("WingtipToyx")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}