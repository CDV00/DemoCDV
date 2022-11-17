namespace SER.Domain.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IDuAnRepository _duAnRepository { get; }
        IKhoKhanRepository _khoKhanRepository { get; }

        Task CommitAsync();
        Task RollbackAsync();
    }
}
