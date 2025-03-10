using InvoiceBackend.Domain.Common;

namespace InvoiceBackend.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : EntityBase<T>;
        int SaveChanges();
    }
}
