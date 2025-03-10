using InvoiceBackend.Domain.Entities;
using InvoiceBackend.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InvoiceBackend.Persistence.Context;

public class HizliBİlDbContext : IdentityDbContext<AppUser, AppRole, Guid, AppUserClaim, AppUserRole, AppUserLogin, AppRoleClaim, AppUserToken>
{
    public HizliBİlDbContext()
    {

    }
    public HizliBİlDbContext(DbContextOptions<HizliBİlDbContext> options) : base(options)
    {

    }

    public DbSet<RefreshToken> RefreshTokens { get; set; }



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(typeof(HizliBİlDbContext).Assembly);
    }
}