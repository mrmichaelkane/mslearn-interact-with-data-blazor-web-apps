using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Data;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DBContextOptions options) : base(options)
    {

    }

    public DbSet<PizzaSpecial> Specials { get; set; }   
}
