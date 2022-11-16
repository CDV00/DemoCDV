namespace SER.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IDuAnRepository _duAnRepository { get; }

        Task CommitAsync();
        Task RollbackAsync();
    }
}
