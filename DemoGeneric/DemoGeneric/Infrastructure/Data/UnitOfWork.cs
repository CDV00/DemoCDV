using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoGeneric.Domain.Interfaces;
using DemoGeneric.Domain.Models;

namespace DemoGeneric.Infrastructure.Data
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly DemoContext _context;
        public ICategoryRepository _CategoryRepository { get; }

        public IProductRepository _ProductRepository { get; }

        public IDetailRepository _DetailRepository { get; }

        public UnitOfWork(DemoContext context, ICategoryRepository categoryRepository, IProductRepository productRepository, IDetailRepository detailRepository)
        {
            _context = context;
            _CategoryRepository = categoryRepository;
            _ProductRepository = productRepository;
            _DetailRepository = detailRepository;
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
