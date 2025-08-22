using EunigosApi.Data;
using EunigosApi.Models.Entity.Common;
using EunigosApi.Models.Entity.CustomerManagement;
using EunigosApi.Models.Entity.UserManagement;
using EunigosApi.Models;
using EunigosApi.Repositories.IRepository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EunigosApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        private IDbContextTransaction? _transaction;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
        public void BeginTransaction()
        {
            _transaction = _db.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction?.Commit();
        }

        public void Rollback()
        {
            _transaction?.Rollback();
        }

        // Implement IDisposable interface for proper cleanup if needed
        public void Dispose()
        {
            _transaction?.Dispose();
            _db.Dispose();
        }
    }
}
