using System.Collections.Generic;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories
{
    public class ClassRepository : IClassRepository
    {
        public ToeicOnlineContext _context;
        public ClassRepository (ToeicOnlineContext context)
        {
            _context = context;
        }

        public IEnumerable<Class> GetClasses()
        {
            return _context.Class;
        }
    }
}