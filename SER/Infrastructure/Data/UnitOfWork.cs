using Microsoft.EntityFrameworkCore;
using SER.Domain.Interfaces;

namespace SER.Infrastructure.Data
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly VI_GPMBContext _context;
        //public ICategoryRepository _CategoryRepository { get; }

        //public IProductRepository _ProductRepository { get; }

        public IDuAnRepository _duAnRepository { get; }

        public UnitOfWork(VI_GPMBContext context, IDuAnRepository duAnRepository)
        {
            _context = context;
            _duAnRepository = duAnRepository;
        }



        //private readonly UserDbContext _context;

        //public IUserRepository _userRepository;

        /*public UnitOfWork(UserDbContext context)
        {
            _context = context;
        }*/

        /*public IUserRepository UserRepository
        {
            get
            {
                return _userRepository = _userRepository ?? new UserRepository(_context);
            }
        }*/
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task RollbackAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
