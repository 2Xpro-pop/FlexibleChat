namespace ChatServer.Dal;
public interface IUnitOfWork : IDisposable
{
    public ICommit BeginTransaction();
}
