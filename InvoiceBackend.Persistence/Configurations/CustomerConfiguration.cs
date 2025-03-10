using InvoiceBackend.Domain.Entities;
using InvoiceBackend.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBackend.Persistence.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.TaxNumber).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
        builder.Property(c => c.Address).HasMaxLength(500);
        builder.Property(c => c.EMail).HasMaxLength(100);

        builder.HasOne<AppUser>().WithMany().HasForeignKey(c => c.CreatedByUserId).OnDelete(DeleteBehavior.NoAction); ;

    }
}
