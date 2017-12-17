using Microsoft.EntityFrameworkCore;

namespace webbapi.Models
{
  public class GroceryListContext : DbContext
  {
    public GroceryListContext(DbContextOptions<GroceryListContext> options)
        : base(options)
    {
    }

    public DbSet<GroceryItem> GroceryList { get; set; }
  }
}