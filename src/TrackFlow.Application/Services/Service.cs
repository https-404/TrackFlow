using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TrackFlow.Application.Interfaces.IRepository;
using TrackFlow.Application.Interfaces.IService;

namespace TrackFlow.Application.Services
{
    public abstract class Service<T> : IService<T> where T : class
    {
        protected readonly IRepository<T> _repository;

        protected Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<T?> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public virtual async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return await _repository.FindAsync(predicate);
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            return await _repository.AddAsync(entity);
        }

        public virtual async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteByIdAsync(id);
        }

        public virtual async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate)
        {
            return await _repository.ExistsAsync(predicate);
        }

        public virtual async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            return await _repository.CountAsync(predicate);
        }
    }
}
