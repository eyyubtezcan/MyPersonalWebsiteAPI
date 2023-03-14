using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using MyPersonalWebsite.Data;
using MyPersonalWebsite.Data.Entities;
using MyPersonalWebsite.Repository.Abstract;
using MyPersonalWebsite.Repository.Concreate;
using MyPersonalWebsite.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalWebsite.Service.Concreate
{
    public class Service<T> : IService<T> where T : class
    {
        protected readonly IRepository<T> _repository;

        public Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _repository.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<T>> GetAllEnumerableAsync()
        {
          return await _repository.GetAllEnumerableAsync();
        }

        public IQueryable<T> GetAllQueryableAsync()
        {
            return  _repository.GetAllQueryableAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public void Remove(T entity)
        {
             _repository.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.SingleOrDefaultAsync(expression);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> expression)
        {
            return  await _repository.Where(expression);
        }
    }
}
