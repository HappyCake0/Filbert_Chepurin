using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public partial class CollectContext : DbContext
{
    public CollectContext()
    {
    }

    public CollectContext(DbContextOptions<CollectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Debt> Debt { get; set; }

    public virtual DbSet<Passport> Passport { get; set; }

    public virtual DbSet<Person> Person { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
            .HasOne(p => p.Passport)
            .WithOne(p => p.Person)
            .HasForeignKey<Passport>(p => p.RPersonId);

        modelBuilder.Entity<Person>()
            .HasMany(p => p.Debts)
            .WithOne(d => d.Person)
            .HasForeignKey(d => d.RPersonId);

        base.OnModelCreating(modelBuilder);
    }

}
