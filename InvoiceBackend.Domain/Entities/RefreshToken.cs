using InvoiceBackend.Domain.Common;

namespace InvoiceBackend.Domain.Entities;

public class RefreshToken : EntityBase<int>
{
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public string SecurityStamp { get; set; }

    public Guid AppUserId { get; set; }
}