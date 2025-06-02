using Microsoft.EntityFrameworkCore;
using MiniDietboxAPI.Domain.Abstractions.Interfaces;
using System.Linq.Expressions;
using MiniDietboxAPI.Domain.Data.Entities.Generics;

namespace MiniDietboxAPI.Domain.Data.Repository.Generics
{
    public class Repository<T> : IRepository<T> where T : class, IBaseEntity
    {
        protected readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>()
                                 .Where(op => op.IsActive && !op.IsDeleted)
                                 .AsNoTracking()
                                 .ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"Entity with ID {id} not found.");
            }
            entity.IsDeleted = true;
            entity.IsActive = false;
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
