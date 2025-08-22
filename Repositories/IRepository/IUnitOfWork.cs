namespace EunigosApi.Repositories.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
