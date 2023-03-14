using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using MyPersonalWebsite.Data;
using MyPersonalWebsite.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using MyPersonalWebsite.Data.Entities;

namespace MyPersonalWebsite.Repository.Concreate
{
    public class Repository<T> : IRepository<T> where T : class

    {
        private  PersonalWebDbContext _context;
        private readonly DbSet<T> _dbSet;
        public Repository(PersonalWebDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
           
        }
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
           
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllEnumerableAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
          
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
           
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.SingleOrDefaultAsync(predicate);
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
 
            return entity;
        }

        public IQueryable<T> GetAllQueryableAsync()
        {
            return _dbSet.AsQueryable();
        }

        public void SaveChanges()
        {
            _context.SaveChangesAsync();
        }
    }
}