using LoginExercise.Context;
using LoginExercise.Core;
using LoginExercise.Core.Repositories;
using LoginExercise.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginExercise.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private UserRepository _userRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            this._context = context;
        }

        public IUserRepository Users => _userRepository = _userRepository ?? new UserRepository(_context);


        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
