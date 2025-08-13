using Acme.Enterprise.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.Enterprise.EntityFrameworkCore.EntityFramework
{
    [ConnectionStringName("Default")]
    public class AcmeEnterpriseDbContext : AbpDbContext<AcmeEnterpriseDbContext>
    {
        public DbSet<Customer> Customers { get; set; }

        public AcmeEnterpriseDbContext(DbContextOptions<AcmeEnterpriseDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Customer>(b =>
            {
                b.ToTable("AcmeCustomers");
                b.ConfigureByConvention();
                b.Property(c => c.Name).IsRequired().HasMaxLength(256);
                b.Property(c => c.Email).HasMaxLength(256);
            });
        }
    }
}
