using InvoiceBackend.Domain.Entities;
using InvoiceBackend.Infrastructure.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBackend.Persistence.Configurations
{
    public class InvoiceLineConfiguration : IEntityTypeConfiguration<InvoiceLine>
    {
        public void Configure(EntityTypeBuilder<InvoiceLine> builder)
        {
            builder.HasKey(il => il.Id);
            builder.Property(il => il.ItemName).IsRequired().HasMaxLength(200);
            builder.Property(il => il.Quentity).IsRequired();
            builder.Property(il => il.Price).HasColumnType("decimal(18,2)");
            builder.HasOne<Invoice>().WithMany().HasForeignKey(il => il.InvoiceId).OnDelete(DeleteBehavior.NoAction); ;
            builder.HasOne<AppUser>().WithMany().HasForeignKey(il => il.CreatedByUserId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
