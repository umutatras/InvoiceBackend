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

public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.HasKey(i => i.Id);
        builder.Property(i => i.InvoiceNumber).IsRequired().HasMaxLength(50);
        builder.Property(i => i.TotalAmount).HasColumnType("decimal(18,2)");
        builder.HasOne<Customer>().WithMany().HasForeignKey(i => i.CustomerId).OnDelete(DeleteBehavior.NoAction); 
        builder.HasOne<AppUser>().WithMany().HasForeignKey(i => i.CreatedByUserId).OnDelete(DeleteBehavior.NoAction); ;
    }
}
