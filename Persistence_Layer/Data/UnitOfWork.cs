using Persistence_Layer.Interfaces;
using Persistence_Layer.Repository;
using System;

namespace Persistence_Layer.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            Group = new GroupRepository(_context);
            _context = context;
        }
        
        public IGroupRepository Group { get; private set; }

        public int Complete()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
