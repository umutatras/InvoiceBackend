using InvoiceBackend.Application.Interfaces;
using InvoiceBackend.Domain.Common;
using InvoiceBackend.Persistence.Context;
using InvoiceBackend.Persistence.Repositories;

namespace InvoiceBackend.Persistence.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly HizliBİlDbContext _context;

    public UnitOfWork(HizliBİlDbContext context)
    {
        _context = context;
    }
    public IRepository<T> GetRepository<T>() where T : EntityBase<T>
    {
        return new Repository<T>(_context);
    }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
}
