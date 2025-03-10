using InvoiceBackend.Domain.Common;
using InvoiceBackend.Infrastructure.Identity;

namespace InvoiceBackend.Domain.Entities;

public sealed class Invoice : EntityBase<int>
{
    public int CustomerId { get; set; }
    public int UserId { get; set; }
    public string InvoiceNumber { get; set; }
    public DateTime InvoiceDate { get; set; }
    public decimal TotalAmount { get; set; }

    #region Navigation Properties
    public Customer Customer { get; set; }
    public AppUser User { get; set; }
    public List<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();
    #endregion
}
