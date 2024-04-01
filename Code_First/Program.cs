using Microsoft.EntityFrameworkCore;

//Proje ayağa kalktığında otomatik Migration oluşturur
ECommerceDbContext context = new();
await context.Database.MigrateAsync();


public class ECommerceDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=ECommerceDb;integrated security=true;TrustServerCertificate=True");
        //Google Connection String yazarsan hangi db ile çalıyorsan onun Connection Stringini öğrenebilirsin
    }
}

//Entity
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
}
//Entity
public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}