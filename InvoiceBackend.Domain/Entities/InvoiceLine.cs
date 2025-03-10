using InvoiceBackend.Domain.Common;
using InvoiceBackend.Infrastructure.Identity;

namespace InvoiceBackend.Domain.Entities;

public sealed class InvoiceLine : EntityBase<int>
{
    public int InvoiceId { get; set; }
    public string ItemName { get; set; }
    public int Quentity { get; set; }
    public decimal Price { get; set; }

    #region Navigation Properties   
    public Invoice Invoice { get; set; }
    #endregion
}
