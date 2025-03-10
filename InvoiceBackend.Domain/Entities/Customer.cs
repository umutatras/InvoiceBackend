using InvoiceBackend.Domain.Common;
using InvoiceBackend.Infrastructure.Identity;

namespace InvoiceBackend.Domain.Entities;

public sealed class Customer : EntityBase<int>
{
    public string TaxNumber { get; set; }
    public string Title { get; set; }
    public string Address { get; set; }
    public string EMail { get; set; }
    public int UserId { get; set; }

    #region Navigation Properties
    public AppUser User { get; set; }
    #endregion
}
