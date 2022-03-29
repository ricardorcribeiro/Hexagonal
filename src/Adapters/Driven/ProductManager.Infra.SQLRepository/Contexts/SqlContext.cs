using Microsoft.EntityFrameworkCore;
using ProductManager.Domain.Entities;
using ProductManager.Domain.Entities.Structs;
using ProductManager.Infra.SQLRepository.Converters;

namespace ProductManager.Infra.SQLRepository.Contexts;
public class SqlContext : DbContext
{
    public SqlContext() { }

    public SqlContext(DbContextOptions<SqlContext> options) : base(options)
    {

    }

    public DbSet<Product> Product { get; set; }
    public DbSet<Inventory> Inventory { get; set; }
    public DbSet<Client> Client { get; set; }
    public DbSet<Buy> Buy { get; set; }
    public DbSet<BuyIten> BuyIten { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly); base.OnModelCreating(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<Cpf>().HaveConversion<CpfConverter>();

        base.ConfigureConventions(configurationBuilder);
    }
}